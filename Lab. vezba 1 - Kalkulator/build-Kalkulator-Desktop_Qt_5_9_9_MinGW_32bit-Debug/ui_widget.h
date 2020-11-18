/********************************************************************************
** Form generated from reading UI file 'widget.ui'
**
** Created by: Qt User Interface Compiler version 5.9.9
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_WIDGET_H
#define UI_WIDGET_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPlainTextEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_Widget
{
public:
    QHBoxLayout *horizontalLayout;
    QVBoxLayout *verticalLayout;
    QLineEdit *le_Rezultat;
    QGridLayout *gridLayout_3;
    QPushButton *btn_Koren;
    QPushButton *btn_Jednako;
    QPushButton *btn_2;
    QPushButton *btn_4;
    QPushButton *btn_6;
    QPushButton *btn_8;
    QPushButton *btn_Deljenje;
    QPushButton *btn_3;
    QPushButton *btn_7;
    QPushButton *btn_Plus;
    QPushButton *btn_PromenaZnaka;
    QPushButton *btn_0;
    QPushButton *btn_Mnozenje;
    QPushButton *btn_Tacka;
    QPushButton *btn_BrisanjeCifre;
    QPushButton *btn_1;
    QPushButton *btn_9;
    QPushButton *btn_Reset;
    QPushButton *btn_5;
    QPushButton *btn_Minus;
    QPlainTextEdit *pte_Istorija;

    void setupUi(QWidget *Widget)
    {
        if (Widget->objectName().isEmpty())
            Widget->setObjectName(QStringLiteral("Widget"));
        Widget->setEnabled(true);
        Widget->resize(843, 503);
        QSizePolicy sizePolicy(QSizePolicy::Preferred, QSizePolicy::Preferred);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(Widget->sizePolicy().hasHeightForWidth());
        Widget->setSizePolicy(sizePolicy);
        horizontalLayout = new QHBoxLayout(Widget);
        horizontalLayout->setObjectName(QStringLiteral("horizontalLayout"));
        verticalLayout = new QVBoxLayout();
        verticalLayout->setObjectName(QStringLiteral("verticalLayout"));
        le_Rezultat = new QLineEdit(Widget);
        le_Rezultat->setObjectName(QStringLiteral("le_Rezultat"));
        le_Rezultat->setEnabled(true);
        QSizePolicy sizePolicy1(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(le_Rezultat->sizePolicy().hasHeightForWidth());
        le_Rezultat->setSizePolicy(sizePolicy1);
        le_Rezultat->setMinimumSize(QSize(0, 100));
        le_Rezultat->setMaximumSize(QSize(16777215, 100));
        QFont font;
        font.setPointSize(18);
        font.setBold(false);
        font.setWeight(50);
        le_Rezultat->setFont(font);
        le_Rezultat->setLayoutDirection(Qt::LeftToRight);
        le_Rezultat->setAutoFillBackground(false);
        le_Rezultat->setAlignment(Qt::AlignRight|Qt::AlignTrailing|Qt::AlignVCenter);
        le_Rezultat->setReadOnly(true);

        verticalLayout->addWidget(le_Rezultat);

        gridLayout_3 = new QGridLayout();
        gridLayout_3->setSpacing(6);
        gridLayout_3->setObjectName(QStringLiteral("gridLayout_3"));
        btn_Koren = new QPushButton(Widget);
        btn_Koren->setObjectName(QStringLiteral("btn_Koren"));
        QSizePolicy sizePolicy2(QSizePolicy::Minimum, QSizePolicy::Preferred);
        sizePolicy2.setHorizontalStretch(0);
        sizePolicy2.setVerticalStretch(0);
        sizePolicy2.setHeightForWidth(btn_Koren->sizePolicy().hasHeightForWidth());
        btn_Koren->setSizePolicy(sizePolicy2);
        QFont font1;
        font1.setPointSize(18);
        font1.setUnderline(false);
        font1.setStrikeOut(false);
        font1.setKerning(true);
        btn_Koren->setFont(font1);

        gridLayout_3->addWidget(btn_Koren, 3, 4, 1, 1);

        btn_Jednako = new QPushButton(Widget);
        btn_Jednako->setObjectName(QStringLiteral("btn_Jednako"));
        sizePolicy2.setHeightForWidth(btn_Jednako->sizePolicy().hasHeightForWidth());
        btn_Jednako->setSizePolicy(sizePolicy2);
        QFont font2;
        font2.setPointSize(18);
        btn_Jednako->setFont(font2);

        gridLayout_3->addWidget(btn_Jednako, 3, 3, 1, 1);

        btn_2 = new QPushButton(Widget);
        btn_2->setObjectName(QStringLiteral("btn_2"));
        sizePolicy2.setHeightForWidth(btn_2->sizePolicy().hasHeightForWidth());
        btn_2->setSizePolicy(sizePolicy2);
        btn_2->setFont(font2);

        gridLayout_3->addWidget(btn_2, 2, 1, 1, 1);

        btn_4 = new QPushButton(Widget);
        btn_4->setObjectName(QStringLiteral("btn_4"));
        sizePolicy2.setHeightForWidth(btn_4->sizePolicy().hasHeightForWidth());
        btn_4->setSizePolicy(sizePolicy2);
        btn_4->setFont(font2);

        gridLayout_3->addWidget(btn_4, 1, 0, 1, 1);

        btn_6 = new QPushButton(Widget);
        btn_6->setObjectName(QStringLiteral("btn_6"));
        sizePolicy2.setHeightForWidth(btn_6->sizePolicy().hasHeightForWidth());
        btn_6->setSizePolicy(sizePolicy2);
        btn_6->setFont(font2);

        gridLayout_3->addWidget(btn_6, 1, 2, 1, 1);

        btn_8 = new QPushButton(Widget);
        btn_8->setObjectName(QStringLiteral("btn_8"));
        sizePolicy2.setHeightForWidth(btn_8->sizePolicy().hasHeightForWidth());
        btn_8->setSizePolicy(sizePolicy2);
        btn_8->setFont(font2);

        gridLayout_3->addWidget(btn_8, 0, 1, 1, 1);

        btn_Deljenje = new QPushButton(Widget);
        btn_Deljenje->setObjectName(QStringLiteral("btn_Deljenje"));
        sizePolicy2.setHeightForWidth(btn_Deljenje->sizePolicy().hasHeightForWidth());
        btn_Deljenje->setSizePolicy(sizePolicy2);
        btn_Deljenje->setFont(font2);

        gridLayout_3->addWidget(btn_Deljenje, 0, 3, 1, 1);

        btn_3 = new QPushButton(Widget);
        btn_3->setObjectName(QStringLiteral("btn_3"));
        sizePolicy2.setHeightForWidth(btn_3->sizePolicy().hasHeightForWidth());
        btn_3->setSizePolicy(sizePolicy2);
        btn_3->setFont(font2);

        gridLayout_3->addWidget(btn_3, 2, 2, 1, 1);

        btn_7 = new QPushButton(Widget);
        btn_7->setObjectName(QStringLiteral("btn_7"));
        sizePolicy2.setHeightForWidth(btn_7->sizePolicy().hasHeightForWidth());
        btn_7->setSizePolicy(sizePolicy2);
        btn_7->setFont(font2);

        gridLayout_3->addWidget(btn_7, 0, 0, 1, 1);

        btn_Plus = new QPushButton(Widget);
        btn_Plus->setObjectName(QStringLiteral("btn_Plus"));
        sizePolicy2.setHeightForWidth(btn_Plus->sizePolicy().hasHeightForWidth());
        btn_Plus->setSizePolicy(sizePolicy2);
        btn_Plus->setFont(font2);

        gridLayout_3->addWidget(btn_Plus, 3, 2, 1, 1);

        btn_PromenaZnaka = new QPushButton(Widget);
        btn_PromenaZnaka->setObjectName(QStringLiteral("btn_PromenaZnaka"));
        sizePolicy2.setHeightForWidth(btn_PromenaZnaka->sizePolicy().hasHeightForWidth());
        btn_PromenaZnaka->setSizePolicy(sizePolicy2);
        btn_PromenaZnaka->setFont(font);

        gridLayout_3->addWidget(btn_PromenaZnaka, 2, 4, 1, 1);

        btn_0 = new QPushButton(Widget);
        btn_0->setObjectName(QStringLiteral("btn_0"));
        sizePolicy2.setHeightForWidth(btn_0->sizePolicy().hasHeightForWidth());
        btn_0->setSizePolicy(sizePolicy2);
        btn_0->setFont(font2);

        gridLayout_3->addWidget(btn_0, 3, 0, 1, 1);

        btn_Mnozenje = new QPushButton(Widget);
        btn_Mnozenje->setObjectName(QStringLiteral("btn_Mnozenje"));
        sizePolicy2.setHeightForWidth(btn_Mnozenje->sizePolicy().hasHeightForWidth());
        btn_Mnozenje->setSizePolicy(sizePolicy2);
        btn_Mnozenje->setFont(font2);

        gridLayout_3->addWidget(btn_Mnozenje, 1, 3, 1, 1);

        btn_Tacka = new QPushButton(Widget);
        btn_Tacka->setObjectName(QStringLiteral("btn_Tacka"));
        sizePolicy2.setHeightForWidth(btn_Tacka->sizePolicy().hasHeightForWidth());
        btn_Tacka->setSizePolicy(sizePolicy2);
        btn_Tacka->setFont(font2);

        gridLayout_3->addWidget(btn_Tacka, 3, 1, 1, 1);

        btn_BrisanjeCifre = new QPushButton(Widget);
        btn_BrisanjeCifre->setObjectName(QStringLiteral("btn_BrisanjeCifre"));
        sizePolicy2.setHeightForWidth(btn_BrisanjeCifre->sizePolicy().hasHeightForWidth());
        btn_BrisanjeCifre->setSizePolicy(sizePolicy2);
        btn_BrisanjeCifre->setFont(font2);

        gridLayout_3->addWidget(btn_BrisanjeCifre, 1, 4, 1, 1);

        btn_1 = new QPushButton(Widget);
        btn_1->setObjectName(QStringLiteral("btn_1"));
        sizePolicy2.setHeightForWidth(btn_1->sizePolicy().hasHeightForWidth());
        btn_1->setSizePolicy(sizePolicy2);
        btn_1->setFont(font2);

        gridLayout_3->addWidget(btn_1, 2, 0, 1, 1);

        btn_9 = new QPushButton(Widget);
        btn_9->setObjectName(QStringLiteral("btn_9"));
        sizePolicy2.setHeightForWidth(btn_9->sizePolicy().hasHeightForWidth());
        btn_9->setSizePolicy(sizePolicy2);
        btn_9->setFont(font2);

        gridLayout_3->addWidget(btn_9, 0, 2, 1, 1);

        btn_Reset = new QPushButton(Widget);
        btn_Reset->setObjectName(QStringLiteral("btn_Reset"));
        sizePolicy2.setHeightForWidth(btn_Reset->sizePolicy().hasHeightForWidth());
        btn_Reset->setSizePolicy(sizePolicy2);
        btn_Reset->setFont(font2);

        gridLayout_3->addWidget(btn_Reset, 0, 4, 1, 1);

        btn_5 = new QPushButton(Widget);
        btn_5->setObjectName(QStringLiteral("btn_5"));
        sizePolicy2.setHeightForWidth(btn_5->sizePolicy().hasHeightForWidth());
        btn_5->setSizePolicy(sizePolicy2);
        btn_5->setFont(font2);

        gridLayout_3->addWidget(btn_5, 1, 1, 1, 1);

        btn_Minus = new QPushButton(Widget);
        btn_Minus->setObjectName(QStringLiteral("btn_Minus"));
        sizePolicy2.setHeightForWidth(btn_Minus->sizePolicy().hasHeightForWidth());
        btn_Minus->setSizePolicy(sizePolicy2);
        btn_Minus->setFont(font2);

        gridLayout_3->addWidget(btn_Minus, 2, 3, 1, 1);


        verticalLayout->addLayout(gridLayout_3);


        horizontalLayout->addLayout(verticalLayout);

        pte_Istorija = new QPlainTextEdit(Widget);
        pte_Istorija->setObjectName(QStringLiteral("pte_Istorija"));
        pte_Istorija->setEnabled(true);
        QSizePolicy sizePolicy3(QSizePolicy::Expanding, QSizePolicy::Expanding);
        sizePolicy3.setHorizontalStretch(0);
        sizePolicy3.setVerticalStretch(0);
        sizePolicy3.setHeightForWidth(pte_Istorija->sizePolicy().hasHeightForWidth());
        pte_Istorija->setSizePolicy(sizePolicy3);
        pte_Istorija->setFont(font2);
        pte_Istorija->setContextMenuPolicy(Qt::DefaultContextMenu);
        pte_Istorija->setReadOnly(true);

        horizontalLayout->addWidget(pte_Istorija);

        horizontalLayout->setStretch(0, 1);
        horizontalLayout->setStretch(1, 1);

        retranslateUi(Widget);

        QMetaObject::connectSlotsByName(Widget);
    } // setupUi

    void retranslateUi(QWidget *Widget)
    {
        Widget->setWindowTitle(QApplication::translate("Widget", "KALKULATOR", Q_NULLPTR));
        le_Rezultat->setText(QString());
        btn_Koren->setText(QApplication::translate("Widget", "\342\210\232", Q_NULLPTR));
        btn_Jednako->setText(QApplication::translate("Widget", "=", Q_NULLPTR));
        btn_2->setText(QApplication::translate("Widget", "2", Q_NULLPTR));
        btn_4->setText(QApplication::translate("Widget", "4", Q_NULLPTR));
        btn_6->setText(QApplication::translate("Widget", "6", Q_NULLPTR));
        btn_8->setText(QApplication::translate("Widget", "8", Q_NULLPTR));
        btn_Deljenje->setText(QApplication::translate("Widget", "/", Q_NULLPTR));
        btn_3->setText(QApplication::translate("Widget", "3", Q_NULLPTR));
        btn_7->setText(QApplication::translate("Widget", "7", Q_NULLPTR));
        btn_Plus->setText(QApplication::translate("Widget", "+", Q_NULLPTR));
        btn_PromenaZnaka->setText(QApplication::translate("Widget", "\342\210\223", Q_NULLPTR));
        btn_0->setText(QApplication::translate("Widget", "0", Q_NULLPTR));
        btn_Mnozenje->setText(QApplication::translate("Widget", "*", Q_NULLPTR));
        btn_Tacka->setText(QApplication::translate("Widget", ".", Q_NULLPTR));
        btn_BrisanjeCifre->setText(QApplication::translate("Widget", "\342\206\220", Q_NULLPTR));
        btn_1->setText(QApplication::translate("Widget", "1", Q_NULLPTR));
        btn_9->setText(QApplication::translate("Widget", "9", Q_NULLPTR));
        btn_Reset->setText(QApplication::translate("Widget", "C", Q_NULLPTR));
        btn_5->setText(QApplication::translate("Widget", "5", Q_NULLPTR));
        btn_Minus->setText(QApplication::translate("Widget", "-", Q_NULLPTR));
    } // retranslateUi

};

namespace Ui {
    class Widget: public Ui_Widget {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_WIDGET_H
