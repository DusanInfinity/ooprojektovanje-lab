/********************************************************************************
** Form generated from reading UI file 'chartviewer.ui'
**
** Created by: Qt User Interface Compiler version 5.9.9
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_CHARTVIEWER_H
#define UI_CHARTVIEWER_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenu>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QToolBar>
#include <chartview.h>

QT_BEGIN_NAMESPACE

class Ui_ChartViewer
{
public:
    QAction *actionLoad_Chart;
    QAction *actionSave_Chart;
    ChartView *centralwidget;
    QMenuBar *menubar;
    QMenu *menuFile;
    QStatusBar *statusbar;
    QToolBar *toolBar;

    void setupUi(QMainWindow *ChartViewer)
    {
        if (ChartViewer->objectName().isEmpty())
            ChartViewer->setObjectName(QStringLiteral("ChartViewer"));
        ChartViewer->resize(805, 636);
        actionLoad_Chart = new QAction(ChartViewer);
        actionLoad_Chart->setObjectName(QStringLiteral("actionLoad_Chart"));
        QIcon icon;
        icon.addFile(QStringLiteral(":/new/ikonice/icons/icon_load.png"), QSize(), QIcon::Normal, QIcon::Off);
        actionLoad_Chart->setIcon(icon);
        actionSave_Chart = new QAction(ChartViewer);
        actionSave_Chart->setObjectName(QStringLiteral("actionSave_Chart"));
        QIcon icon1;
        icon1.addFile(QStringLiteral(":/new/ikonice/icons/icon_save.png"), QSize(), QIcon::Normal, QIcon::Off);
        actionSave_Chart->setIcon(icon1);
        centralwidget = new ChartView(ChartViewer);
        centralwidget->setObjectName(QStringLiteral("centralwidget"));
        ChartViewer->setCentralWidget(centralwidget);
        menubar = new QMenuBar(ChartViewer);
        menubar->setObjectName(QStringLiteral("menubar"));
        menubar->setGeometry(QRect(0, 0, 805, 21));
        menuFile = new QMenu(menubar);
        menuFile->setObjectName(QStringLiteral("menuFile"));
        ChartViewer->setMenuBar(menubar);
        statusbar = new QStatusBar(ChartViewer);
        statusbar->setObjectName(QStringLiteral("statusbar"));
        ChartViewer->setStatusBar(statusbar);
        toolBar = new QToolBar(ChartViewer);
        toolBar->setObjectName(QStringLiteral("toolBar"));
        ChartViewer->addToolBar(Qt::TopToolBarArea, toolBar);

        menubar->addAction(menuFile->menuAction());
        menuFile->addAction(actionLoad_Chart);
        menuFile->addAction(actionSave_Chart);
        toolBar->addAction(actionLoad_Chart);
        toolBar->addAction(actionSave_Chart);

        retranslateUi(ChartViewer);

        QMetaObject::connectSlotsByName(ChartViewer);
    } // setupUi

    void retranslateUi(QMainWindow *ChartViewer)
    {
        ChartViewer->setWindowTitle(QApplication::translate("ChartViewer", "ChartViewer", Q_NULLPTR));
        actionLoad_Chart->setText(QApplication::translate("ChartViewer", "Load Chart", Q_NULLPTR));
        actionSave_Chart->setText(QApplication::translate("ChartViewer", "Save Chart", Q_NULLPTR));
        menuFile->setTitle(QApplication::translate("ChartViewer", "File", Q_NULLPTR));
        toolBar->setWindowTitle(QApplication::translate("ChartViewer", "toolBar", Q_NULLPTR));
    } // retranslateUi

};

namespace Ui {
    class ChartViewer: public Ui_ChartViewer {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_CHARTVIEWER_H
