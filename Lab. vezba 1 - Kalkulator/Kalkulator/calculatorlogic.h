#ifndef CALCULATORLOGIC_H
#define CALCULATORLOGIC_H

#include <QObject>

class CalculatorLogic : public QObject
{
    Q_OBJECT
public:
    explicit CalculatorLogic(QObject *parent = nullptr);
    void doCommand(QString);

signals:
    void resultChanged(QString);
    void resultHistoryChanged(QString);

private:
    QString currentResult;
    QString lastOperation;
    bool operationChosen;
    double firstNumber;
    bool firstNumberEntered;
    bool equalsPressed;


    void ResetCalculator();
    void ErrorMessage(QString);

};

#endif // CALCULATORLOGIC_H
