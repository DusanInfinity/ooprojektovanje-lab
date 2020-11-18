#include "widget.h"
#include "ui_widget.h"
#include <QDebug>

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget)
{
    ui->setupUi(this);
    calculator = new CalculatorLogic(this); // Kreiranje objekta kalkulatora

    connect(ui->btn_0, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_1, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_2, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_3, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_4, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_5, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_6, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_7, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_8, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_9, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_BrisanjeCifre, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_Deljenje, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_Jednako, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_Koren, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_Minus, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_Mnozenje, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_Plus, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_PromenaZnaka, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_Reset, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->btn_Tacka, SIGNAL(clicked()), this, SLOT(onBtnClicked()));

    connect(calculator, SIGNAL(resultChanged(QString)), this, SLOT(onResultChanged(QString)));
    connect(calculator, SIGNAL(resultHistoryChanged(QString)), this, SLOT(onResultHistoryChanged(QString)));
}

Widget::~Widget()
{
    delete ui;
}

void Widget::onBtnClicked()
{
    QObject *senderPtr = this->sender();

    QString buttonText = "undefined";
    if(senderPtr == ui->btn_BrisanjeCifre)
        buttonText = "BrisanjeCifre";
    else if(senderPtr == ui->btn_Koren)
        buttonText = "Korenovanje";
    else if(senderPtr == ui->btn_PromenaZnaka)
        buttonText = "PromenaZnaka";
    else
        buttonText = senderPtr->property("text").toString();

    calculator->doCommand(buttonText);
}

void Widget::onResultChanged(QString result)
{
    ui->le_Rezultat->setText(result); // postavljamo trenutni rezultat
}

void Widget::onResultHistoryChanged(QString resultHistory)
{
    ui->pte_Istorija->appendPlainText(resultHistory); // Dodajemo novu liniju sa racunicom
}
























