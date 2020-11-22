#include "calculatorlogic.h"
#include <QtMath>
#include <QDebug>
#include <QMessageBox>
//#include "velikibroj.h"

CalculatorLogic::CalculatorLogic(QObject *parent) : QObject(parent)
{
    ResetCalculator();
}

void CalculatorLogic::ResetCalculator()
{
    currentResult = ""; // Prazan string
    lastOperation = ""; // Prazan string
    firstNumber = 0;
    firstNumberEntered = false;
    operationChosen = false;
    equalsPressed = false;
}


void CalculatorLogic::doCommand(QString cmd)
{
    if(cmd == "0" || cmd == "1" || cmd == "2" || cmd == "3" || cmd == "4" || cmd == "5" || cmd == "6" || cmd == "7" || cmd == "8" || cmd == "9")
    {
        if(equalsPressed) // Po ugledu na Windows 10 kalkulator, ukoliko se klikne "=" i nakon toga se klikne neki broj, kalkulator se resetuje i unosi dati broj
        {
            ResetCalculator();
            currentResult = cmd;
        }
        else
        {
            if(operationChosen)
            {
                firstNumber = currentResult.toDouble();
                currentResult = cmd;
                operationChosen = false;
                firstNumberEntered = true;
            }
            else currentResult += cmd;
        }

    }
    else if(cmd == ".")
    {
        if(currentResult.length() > 0)
        {
            if(!currentResult.contains(".")) // Provera da li vec postoji jedna tacka
                currentResult += cmd;
        }
        else
            currentResult = "0" + cmd;
    }
    else if(cmd == "C") // brisanje
    {
        qDebug("Pritisnuo si dugme za potpuno brisanje!");
        ResetCalculator();
    }
    else if(cmd == "BrisanjeCifre")
    {
        qDebug("Pritisnuo si dugme za brisanje poslednjeg unosa!");
        int brKaraktera = currentResult.length();
        if(brKaraktera > 0) // provera da li uopste ima teksta
        {
            currentResult.remove(brKaraktera-1, 1);
        }
    }
    else if(cmd == "Korenovanje")
    {
        qDebug("Pritisnuo si dugme za korenovanje!");
        if(currentResult.length() > 0) // provera da li uopste ima sta da se korenuje
        {
            qDebug("[DEBUG] Postoji tekst, sledi konvertovanje!");
            bool successfulConv;
            double broj = currentResult.toDouble(&successfulConv);
            if(successfulConv)
            {
                qDebug() << "[DEBUG] Konvertovanje uspesno -> " << broj;
                if(broj < 0) {
                    ErrorMessage("Ne možete korenovati negativan broj!");
                    return;
                }
                double noviBroj = qSqrt(broj);
                currentResult = QString::number(noviBroj);
            }
        }
    }
    else if(cmd == "PromenaZnaka")
    {
        qDebug("Pritisnuo si dugme za promenu znaka!");
        if(currentResult.length() > 0) // provera da li uopste postoji nesto u stringu
        {
            qDebug("[DEBUG] Postoji tekst, sledi konvertovanje!");
            bool successfulConv;
            double broj = currentResult.toDouble(&successfulConv);
            if(successfulConv)
            {
                qDebug() << "[DEBUG] Konvertovanje uspesno -> " << broj;
                double noviBroj = -broj;
                currentResult = QString::number(noviBroj);
            }
        }
    }
    else if(cmd == "+" || cmd == "-" || cmd == "*" || cmd == "/") // Operacije
    {
        qDebug() << "Pritisnuo si dugme " << cmd;
        // Ukoliko je vec odabrana jedna operacija i vec postoje 2 operanda, ta operacija se izvrsi a potom se rezultat te operacije koristi kao prvi operand za narednu operaciju
        if(lastOperation.length() > 0 && firstNumberEntered && !equalsPressed) // Vrsimo proveru i da li je bio pritisnut znak jednako jer u tom slucaju je vec izvrsena poslednja operacija
            doCommand("=");

        if(currentResult.length() > 0) // provera da li uopste postoji nesto u stringu, na cemu moze da se izvrsi operacija
        {
            lastOperation = cmd;
            operationChosen = true;
            equalsPressed = false;
        }
    }
    else if(cmd == "=") // Operacije
    {
        qDebug() << "Pritisnuo si dugme =";
        if(lastOperation.length() > 0 && currentResult.length() > 0) // provera da li uopste postoji operacija koja bi se izvrsila kao i drugi operand
        {
            double secondNumber = currentResult.toDouble();
            if(firstNumberEntered == false) // Ukoliko igrac unese samo jedan broj i recimo odabere mnozenje, svaki put kad se klikne =, broj ce da se pomnozi prethodnim rezultatom
            {
                firstNumber = secondNumber;
                firstNumberEntered = true;
            }

            double result = 0;
            if(lastOperation == "+")
            {
                result = firstNumber + secondNumber;
                currentResult = QString::number(result);
            }
            else if(lastOperation == "-")
            {
                result = firstNumber - secondNumber;
                currentResult = QString::number(result);
            }
            else if(lastOperation == "*")
            {
                result = firstNumber * secondNumber;
                currentResult = QString::number(result);
            }
            else if(lastOperation == "/")
            {
                if(secondNumber == 0) {
                    ErrorMessage("Ne možete deliti nulom!");
                    return;
                }
                result = firstNumber / secondNumber;
                currentResult = QString::number(result);
            }
            else { return; } // invalid operacija

            emit resultHistoryChanged(QString::number(firstNumber) + lastOperation + QString::number(secondNumber) + "=" + currentResult);
            emit resultChanged(currentResult);
            equalsPressed = true;

            return;
        }
    }
    else if(cmd == "FUNC2020")
    {
        qDebug() << "Pritisnuo si dugme FUNC2020";
        // y = x^2020 - DS(x^2020)
        // Broj x^2020 mozemo predstaviti kao Dm-1*10^m-1 + Dm-2*10^m-2 + ... D0*10^0, gde m broj cifara tog broja a D0, D1, ... Dm-1 cifre na 0., 1. ..., m-1. poziciji u broju-> Suma(Dk*10^k), gde je k = 0, 1,..., m-1
        // Zbir cifara DS(x^2020) mozemo zapisati kao Dm-1+Dm-2+...+D0 -> Suma(Dk), gde je k = 0, 1,..., m-1

        // Sada imamo da je y = Suma(Dk*10^k) - Suma(Dk), gde je k = 0, 1,..., m-1
        // Sve to mozemo da stavimo pod zajednicku sumu, pa imamo: y = Suma(Dk*10^k - Dk), gde je k = 0, 1,..., m-1
        // => y = Suma(Dk*(10^k - 1)), gde je k = 0, 1,..., m-1
        // 10^k - 1 ce biti broj sa k devetki, osim u slucaju kad je k = 0, tad ce biti 10^0-1 = 1-1 = 0
        // Primer: k = 2, 100-1= 99
        // Kako znamo da je broj sa svim devetkama deljiv sa 9, iz toga sledi da ce broj y uvek biti deljiv sa 9, pa samim tim sigurno nije prost broj
        // Iz tog razloga, ne moramo nista da pisemo u ovom delu, jer sigurno nikad nece biti ispisano 2020 na display-u

        // Zakomentarisao sam sav kod koji sam pisao a koji nije deo ovog resenja, da bude kao podsetnik sta se desava kad se razmislja u pogresnom smeru


        /*if(currentResult.length() > 0) // provera da li postoji nesto na display-u
        {
            bool succ;
            int number = currentResult.toInt(&succ);
            if(succ && (number > 1 || number < -1)) // ako je u pitanju ceo broj na display-u, izvrsi funkciju
            {
                //for(int i = 2; i < 10000; i++)
               // {
                    if(prostBroj2020(number)) // ako je dati broj prost, prikazujemo 2020
                    {
                        emit resultChanged("2020");// + QString::number(i));
                     //   break;
                    }
              //  }
            }
        } */
        return;
    }
    else { return; } // Invalid simboli

    emit resultChanged(currentResult);
}

void CalculatorLogic::ErrorMessage(QString errorMsg)
{
    emit resultChanged(errorMsg);
    ResetCalculator();
    //QMessageBox msgBox;
    //msgBox.critical(nullptr, "GREŠKA", errorMsg);
}


///////////////////////////////////////////////////////
///////////////////////////////////////////////////////
///////////////////////////////////////////////////////
///////////////////////////////////////////////////////
///////////////////////////////////////////////////////
///////////////////////////////////////////////////////
///////////////////////////////////////////////////////

/*
int CalculatorLogic::zbirCifara(int broj) // funkcija koja izracunava zbir cifara nekog broja
{
    int suma = 0;
    while(broj > 0)
    {
        suma += broj%10; // uzima se cifra najmanje tezine i dodaje u sumu
        broj /= 10; // Delimo sa 10 i time "izbacujemo" cifru najmanje tezine jer je vec uracunata u sumu
    }
    return suma;
}

bool CalculatorLogic::prostBroj(int broj) // funkcija koja proverava da li je dati broj prost
{
    if(broj < 2) return false;
    for(long long unsigned int i = 2, j = broj/2; i < j; i++)
    {
        if(broj%i == 0)
            return false; // nije prost jer postoji broj od 2 do broj/2 koji ga deli bez ostatka
    }
    return true;
}
bool CalculatorLogic::prostBroj2020(int broj)
{
    int br = qPow(broj, 2);
    qDebug() << "Broj " << broj << "^2 :" << br;
    int zc = zbirCifara(br);
    qDebug() << "Zbir cifara:" << zc;
    br -= zc;

    qDebug() << "Broj " << broj << "^1020 :" << pow2020(broj, 1020);
    qDebug() << "Broj " << broj << "^2017 :" << pow2020(broj, 2017);
    qDebug() << "Broj " << broj << "^2020 :" << pow2020(broj, 2020);

    //if(prostBroj(br))
    //    return true;

    return false;
} */


/*
bool CalculatorLogic::prostBroj2020(int broj) // funkcija koja proverava da li je dati broj prost za nas specijalan slucaj broj^2020-zbirCifara(broj)
{
    // Svaki prost broj > 3 moze se predstaviti u obliku 6k+1 ili 6k-1, keN.

    VelikiBroj velikiBroj;
    int brCifaraVelikogBroja = velikiBroj.pomnoziIVratiBrojCifara(broj, 2020);
    qDebug() << "Vrednost velikog broja" << broj << "^2020" << "nakon mnozenja: ";
    velikiBroj.prikaziBroj();

    int zbirCifara = velikiBroj.vratiZbirCifara();
    qDebug() << "Zbir cifara broja" << broj << "^2020 :" << zbirCifara;

    //if(broj%2 == 0 && zbirCifara%2 == 0) return false; // dva parna broja, razlika je sigurno parna i taj broj sigurno nije prost
    //if(broj%2 == 1 && zbirCifara%2 == 1) return false; // dva neparna broja, razlika je sigurno parna i taj broj sigurno nije prost


    velikiBroj.oduzmiZbirCifara(zbirCifara);
    qDebug() << "Vrednost velikog broja nakon oduzimanja zbira cifara" << zbirCifara << ":";
    velikiBroj.prikaziBroj();
    zbirCifara = velikiBroj.vratiZbirCifara();
    qDebug() << "Zbir cifara nakon oduzimanja" << zbirCifara;

    //if(zbirCifara % 9 != 0) // Dodato zbog testa deljivosti na broj 9, zbog provere
    //{
    //    return true;
    //}

    qDebug() << "Broj cifara: " << brCifaraVelikogBroja;

    // Dobili smo broj, sada M, sada od njega pravimo broj oblika M = 6k-1 odnosno M = 6k+1
    // Sada proveravamo da li je dati broj deljiv sa 2 i 3 odnosno da li je deljiv sa 6, i to u dva slucaja, kada oduzimamo 1 i kada dodajemo 1

    if(velikiBroj.velikiBroj[0]-1 % 2 == 0) // provera da li broj moze da se predstavi u obliku 6k+1 (6k-1+1 -> iz tog razloga oduzimamo 1)
    { // Da bi bio deljiv sa 2, mora biti paran, slobodno mozemo da proverimo cifru najmanje tezine da li je 0, 2, 4, 6, 8
        // Sada kada znamo da je broj deljiv sa 2, proveravamo da li je deljiv i sa 3, za to je potrebno da nam je zbir cifara velikog broja deljiv sa 3
        zbirCifara--; // Oduzimamo 1 po uslovu

        if(zbirCifara % 3 == 0)
        {
            return true; // Ako je deljiv sa 2 i sa 3, onda je broj deljiv sa 6, sto znaci da moze da se predstavi kao 6*K+1 gde je KeN
        }
    }
    else if(velikiBroj.velikiBroj[0]+1 % 2 == 0) // provera da li broj moze da se predstavi u obliku 6k-1 (6k+1-1 -> iz tog razloga dodajemo 1)
    { // Da bi bio deljiv sa 2, mora biti paran, slobodno mozemo da proverimo cifru najmanje tezine da li je 0, 2, 4, 6, 8
        // Sada kada znamo da je broj deljiv sa 2, proveravamo da li je deljiv i sa 3, za to je potrebno da nam je zbir cifara velikog broja deljiv sa 3
        zbirCifara++; // Dodajemo 1 po uslovu

        if(zbirCifara % 3 == 0)
        {
            return true; // Ako je deljiv sa 2 i sa 3, onda je broj deljiv sa 6, sto znaci da moze da se predstavi kao 6*K-1 gde je KeN
        }
    }

    return false; // Ako nijedan od uslova nije ispunjen, broj je slozen
} */

/*
int CalculatorLogic::pow2020(int broj, int stepen = 2020) // radimo stepenovanje po modulu 1000, cilj je da dobijemo cifre manje tezine
{
    int br = 1;
    for(int i = 1; i <= stepen; i++)
        br = (br * broj)%100000;

    return br;
} */
