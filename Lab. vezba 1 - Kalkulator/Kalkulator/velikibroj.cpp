/*#include "velikibroj.h"
#include <QtDebug>

VelikiBroj::VelikiBroj(QObject *parent, int maxBrCifara) : QObject(parent)
{
    // TO-DO iskoristiti maxBrCifara, dodati destruktor, dinamicka alokacija
    ukupnoCifara = 0;
}

void VelikiBroj::prikaziBroj()
{
    if(ukupnoCifara == 0) return;
    QString br;
    for (int i = ukupnoCifara - 1; i >= 0; i--)
        br += QString::number(velikiBroj[i]);
    qDebug() << br;
}

// Zasluge za ideju stepenovanja velikog broja: https://www.geeksforgeeks.org/writing-power-function-for-large-numbers/
int VelikiBroj::pomnoziIVratiBrojCifara(int broj, int n)
{
    ukupnoCifara = 0;
    int temp = broj;

    // Inicijalizacija
    while (temp != 0) {
        velikiBroj[ukupnoCifara++] = temp % 10;
        temp = temp / 10;
    }

    // Mnozenje n puta, povecavanje broja cifara
    for (int i = 2; i <= n; i++)
        ukupnoCifara = pomnoziSaPrenosom(broj, ukupnoCifara);

    return ukupnoCifara;
}

int VelikiBroj::pomnoziSaPrenosom(int broj, int brCifara) // mnozenje, izracunavanje prenosa i povecavanje niza - broja cifara
{
    int carry = 0;

    // Pomnozi broj sa trenutnim rezultatom i uracunaj prenos
    for (int i = 0; i < brCifara; i++) {
        int prod = velikiBroj[i] * broj + carry;

        // Cifra moze biti od 0-9, sve preko toga je prenos
        velikiBroj[i] = prod % 10;
        carry = prod / 10;
    }

    // Nakon mnozenja, ukoliko postoji prenos dodajemo ga u niz cifara, cifru po cifru i povecavamo broj cifara tog velikog broja
    while (carry) {
        velikiBroj[brCifara] = carry % 10;
        carry = carry / 10;
        brCifara++;
    }
    return brCifara;
}

void VelikiBroj::oduzmiZbirCifara(int zbir)
{
    int ukupnoCifaraZbira = 0;
    int temp = zbir;
    int nizCifara[50];
    while(temp != 0) // racunamo koliko cifara zapravo ima zbir cifara i inicijalizujemo niz za dalju racunicu
    {
        nizCifara[ukupnoCifaraZbira++] = temp % 10;
        temp /= 10;
    }

    int i = 0;
    while(i < ukupnoCifaraZbira)
    {
        if(velikiBroj[i] < nizCifara[i]) // ako je cifra manja, vrsimo pozajmicu
        {
            velikiBroj[i] += 10;
            velikiBroj[i+1]--;
        }
        velikiBroj[i] -= nizCifara[i];
        i++;
    }
    while(i < ukupnoCifara && velikiBroj[i] < 0)
    {
        if(velikiBroj[i] < 0)  // u slucaju da je u poslednjoj pozajmici bila 0, na tom mestu ce sad biti -1 i zato to moramo da ispravimo tako sto nadalje pozajmljujemo sve dok postoji cifra manja od 0
        {
            velikiBroj[i] += 10;
            velikiBroj[i+1]--;
        }
        i++;
    }
}

int VelikiBroj::vratiZbirCifara()
{
    if(ukupnoCifara == 0) return 0;
    int zbir = 0;
    for (int i = ukupnoCifara - 1; i >= 0; i--)
        zbir += velikiBroj[i];

    return zbir;
}*/
