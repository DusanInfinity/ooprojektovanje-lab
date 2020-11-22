#include "chartviewer.h"
#include "ui_chartviewer.h"
#include <QMessageBox>
#include <QDebug>
#include <QFileDialog>

ChartViewer::ChartViewer(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::ChartViewer)
{
    ui->setupUi(this);
}

ChartViewer::~ChartViewer()
{
    delete ui;
}


void ChartViewer::on_actionLoad_Chart_triggered()
{
    QString fileName = QFileDialog::getOpenFileName(this, this->windowTitle() + " - Ucitavanje fajla", QDir::currentPath(), "Teksualni fajlovi (*.txt)");
    if(!fileName.isEmpty())
    {
        m_chartDoc.loadChartFromFile(fileName);
    }
}

void ChartViewer::on_actionSave_Chart_triggered()
{
    QString fileName = QFileDialog::getSaveFileName(this, this->windowTitle() + " - Cuvanje fajla", QDir::currentPath(), "Teksualni fajlovi (*.txt)");
    if(!fileName.isEmpty())
    {
        m_chartDoc.saveChartToFile(fileName);
    }
}
