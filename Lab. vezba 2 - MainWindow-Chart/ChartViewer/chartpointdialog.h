#ifndef CHARTPOINTDIALOG_H
#define CHARTPOINTDIALOG_H

#include <QDialog>

namespace Ui {
class ChartPointDialog;
}

class ChartPointDialog : public QDialog
{
    Q_OBJECT

public:
    explicit ChartPointDialog(QWidget *parent = nullptr);
    ~ChartPointDialog();
    void setData(QString l, float v, QColor c);
    QString getLabel();
    QString getValue();
    QString getColor();

private slots:
    void onColorPickButtonClick();

private:
    Ui::ChartPointDialog *ui;
};

#endif // CHARTPOINTDIALOG_H
