#include "calculatorlogic.h"
#include <QtMath>
#include <QDebug>
#include <QMessageBox>

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
