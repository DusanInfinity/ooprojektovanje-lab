/*#ifndef VELIKIBROJ_H
#define VELIKIBROJ_H

#include <QObject>

class VelikiBroj : public QObject
{
    Q_OBJECT

private:


public:
    explicit VelikiBroj(QObject *parent = nullptr, int maxCifara = 20000);
    int pomnoziSaPrenosom(int, int);
    int pomnoziIVratiBrojCifara(int, int);
    void oduzmiZbirCifara(int);
    void prikaziBroj();
    int velikiBroj[20000]; // TO-DO prebaciti kasnije u pointer
    int ukupnoCifara;
    int vratiZbirCifara();

signals:

};

#endif // VELIKIBROJ_H
*/
