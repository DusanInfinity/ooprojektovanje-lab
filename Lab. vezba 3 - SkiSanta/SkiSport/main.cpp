#include "skisport.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    SkiSport w;
    w.show();
    return a.exec();
}
