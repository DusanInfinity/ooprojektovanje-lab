#ifndef SKISPORT_H
#define SKISPORT_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui { class SkiSport; }
QT_END_NAMESPACE

class SkiSport : public QMainWindow
{
    Q_OBJECT

public:
    SkiSport(QWidget *parent = nullptr);
    ~SkiSport();

private:
    Ui::SkiSport *ui;
};
#endif // SKISPORT_H
