/********************************************************************************
** Form generated from reading UI file 'chartpointdialog.ui'
**
** Created by: Qt User Interface Compiler version 5.9.9
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_CHARTPOINTDIALOG_H
#define UI_CHARTPOINTDIALOG_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QDialog>
#include <QtWidgets/QDialogButtonBox>
#include <QtWidgets/QFormLayout>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QVBoxLayout>

QT_BEGIN_NAMESPACE

class Ui_ChartPointDialog
{
public:
    QVBoxLayout *verticalLayout;
    QFormLayout *formLayout;
    QLabel *label;
    QLineEdit *leLabel;
    QLabel *label_2;
    QLineEdit *leValue;
    QLabel *colorLabel;
    QHBoxLayout *horizontalLayout;
    QLineEdit *leColor;
    QPushButton *btnColorPicker;
    QDialogButtonBox *buttonBox;

    void setupUi(QDialog *ChartPointDialog)
    {
        if (ChartPointDialog->objectName().isEmpty())
            ChartPointDialog->setObjectName(QStringLiteral("ChartPointDialog"));
        ChartPointDialog->resize(197, 130);
        verticalLayout = new QVBoxLayout(ChartPointDialog);
        verticalLayout->setObjectName(QStringLiteral("verticalLayout"));
        verticalLayout->setSizeConstraint(QLayout::SetDefaultConstraint);
        formLayout = new QFormLayout();
        formLayout->setObjectName(QStringLiteral("formLayout"));
        formLayout->setSizeConstraint(QLayout::SetMaximumSize);
        formLayout->setHorizontalSpacing(30);
        label = new QLabel(ChartPointDialog);
        label->setObjectName(QStringLiteral("label"));

        formLayout->setWidget(0, QFormLayout::LabelRole, label);

        leLabel = new QLineEdit(ChartPointDialog);
        leLabel->setObjectName(QStringLiteral("leLabel"));
        QSizePolicy sizePolicy(QSizePolicy::Expanding, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(leLabel->sizePolicy().hasHeightForWidth());
        leLabel->setSizePolicy(sizePolicy);

        formLayout->setWidget(0, QFormLayout::FieldRole, leLabel);

        label_2 = new QLabel(ChartPointDialog);
        label_2->setObjectName(QStringLiteral("label_2"));

        formLayout->setWidget(1, QFormLayout::LabelRole, label_2);

        leValue = new QLineEdit(ChartPointDialog);
        leValue->setObjectName(QStringLiteral("leValue"));

        formLayout->setWidget(1, QFormLayout::FieldRole, leValue);

        colorLabel = new QLabel(ChartPointDialog);
        colorLabel->setObjectName(QStringLiteral("colorLabel"));

        formLayout->setWidget(2, QFormLayout::LabelRole, colorLabel);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QStringLiteral("horizontalLayout"));
        leColor = new QLineEdit(ChartPointDialog);
        leColor->setObjectName(QStringLiteral("leColor"));

        horizontalLayout->addWidget(leColor);

        btnColorPicker = new QPushButton(ChartPointDialog);
        btnColorPicker->setObjectName(QStringLiteral("btnColorPicker"));
        QSizePolicy sizePolicy1(QSizePolicy::Fixed, QSizePolicy::Preferred);
        sizePolicy1.setHorizontalStretch(0);
        sizePolicy1.setVerticalStretch(0);
        sizePolicy1.setHeightForWidth(btnColorPicker->sizePolicy().hasHeightForWidth());
        btnColorPicker->setSizePolicy(sizePolicy1);
        btnColorPicker->setMinimumSize(QSize(30, 0));
        btnColorPicker->setMaximumSize(QSize(30, 16777215));

        horizontalLayout->addWidget(btnColorPicker);


        formLayout->setLayout(2, QFormLayout::FieldRole, horizontalLayout);


        verticalLayout->addLayout(formLayout);

        buttonBox = new QDialogButtonBox(ChartPointDialog);
        buttonBox->setObjectName(QStringLiteral("buttonBox"));
        buttonBox->setOrientation(Qt::Horizontal);
        buttonBox->setStandardButtons(QDialogButtonBox::Cancel|QDialogButtonBox::Ok);

        verticalLayout->addWidget(buttonBox);


        retranslateUi(ChartPointDialog);
        QObject::connect(buttonBox, SIGNAL(accepted()), ChartPointDialog, SLOT(accept()));
        QObject::connect(buttonBox, SIGNAL(rejected()), ChartPointDialog, SLOT(reject()));

        QMetaObject::connectSlotsByName(ChartPointDialog);
    } // setupUi

    void retranslateUi(QDialog *ChartPointDialog)
    {
        ChartPointDialog->setWindowTitle(QApplication::translate("ChartPointDialog", "Dialog", Q_NULLPTR));
        label->setText(QApplication::translate("ChartPointDialog", "Label", Q_NULLPTR));
        label_2->setText(QApplication::translate("ChartPointDialog", "Value", Q_NULLPTR));
        colorLabel->setText(QApplication::translate("ChartPointDialog", "Color", Q_NULLPTR));
        btnColorPicker->setText(QApplication::translate("ChartPointDialog", "...", Q_NULLPTR));
    } // retranslateUi

};

namespace Ui {
    class ChartPointDialog: public Ui_ChartPointDialog {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_CHARTPOINTDIALOG_H
