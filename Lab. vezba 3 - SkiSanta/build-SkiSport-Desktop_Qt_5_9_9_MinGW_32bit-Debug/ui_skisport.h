/********************************************************************************
** Form generated from reading UI file 'skisport.ui'
**
** Created by: Qt User Interface Compiler version 5.9.9
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SKISPORT_H
#define UI_SKISPORT_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QStatusBar>
#include <skiview.h>

QT_BEGIN_NAMESPACE

class Ui_SkiSport
{
public:
    SkiView *centralwidget;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *SkiSport)
    {
        if (SkiSport->objectName().isEmpty())
            SkiSport->setObjectName(QStringLiteral("SkiSport"));
        SkiSport->resize(708, 614);
        centralwidget = new SkiView(SkiSport);
        centralwidget->setObjectName(QStringLiteral("centralwidget"));
        centralwidget->setFocusPolicy(Qt::ClickFocus);
        SkiSport->setCentralWidget(centralwidget);
        menubar = new QMenuBar(SkiSport);
        menubar->setObjectName(QStringLiteral("menubar"));
        menubar->setGeometry(QRect(0, 0, 708, 21));
        SkiSport->setMenuBar(menubar);
        statusbar = new QStatusBar(SkiSport);
        statusbar->setObjectName(QStringLiteral("statusbar"));
        SkiSport->setStatusBar(statusbar);

        retranslateUi(SkiSport);

        QMetaObject::connectSlotsByName(SkiSport);
    } // setupUi

    void retranslateUi(QMainWindow *SkiSport)
    {
        SkiSport->setWindowTitle(QApplication::translate("SkiSport", "SkiSport", Q_NULLPTR));
    } // retranslateUi

};

namespace Ui {
    class SkiSport: public Ui_SkiSport {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SKISPORT_H
