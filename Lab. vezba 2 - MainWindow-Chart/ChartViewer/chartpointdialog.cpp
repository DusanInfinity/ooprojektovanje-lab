#include "chartpointdialog.h"
#include "ui_chartpointdialog.h"
#include <QColorDialog>
#include <QColor>

ChartPointDialog::ChartPointDialog(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::ChartPointDialog)
{
    ui->setupUi(this);
    setWindowTitle("Izmena stuba");
    connect(ui->btnColorPicker, SIGNAL(clicked()), this, SLOT(onColorPickButtonClick()));
}

ChartPointDialog::~ChartPointDialog()
{
    delete ui;
}

void ChartPointDialog::setData(QString l, float v, QColor c)
{
    ui->leLabel->setText(l);
    ui->leValue->setText(QString::number(v));
    ui->leColor->setText(c.name());
}


void ChartPointDialog::onColorPickButtonClick()
{
    QColor color = QColorDialog::getColor(QColor(ui->leColor->text()), this, this->windowTitle() + " - Izbor boje");
    if(color.isValid())
    {
        ui->leColor->setText(color.name());
    }
}

QString ChartPointDialog::getLabel()
{
    return ui->leLabel->text();
}
QString ChartPointDialog::getValue()
{
    return ui->leValue->text();
}
QString ChartPointDialog::getColor()
{
    return ui->leColor->text();
}

