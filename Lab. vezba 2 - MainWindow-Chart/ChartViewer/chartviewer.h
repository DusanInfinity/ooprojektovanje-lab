#ifndef CHARTVIEWER_H
#define CHARTVIEWER_H

#include <QMainWindow>
#include "chartdoc.h"

QT_BEGIN_NAMESPACE
namespace Ui { class ChartViewer; }
QT_END_NAMESPACE

class ChartViewer : public QMainWindow
{
    Q_OBJECT

public:
    ChartViewer(QWidget *parent = nullptr);
    ~ChartViewer();

private slots:
    void on_actionLoad_Chart_triggered();
    void on_actionSave_Chart_triggered();

private:
    Ui::ChartViewer *ui;
    ChartDoc m_chartDoc;
};
#endif // CHARTVIEWER_H
