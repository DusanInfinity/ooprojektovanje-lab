#ifndef SKISANTA_H
#define SKISANTA_H

#include <QObject>
#include <QImage>

class SkiSanta : public QObject
{
    Q_OBJECT
    int x;
    int y;
    int w;
    int h;
    QList<QImage> *images;
    int currentState; // 0 - levo, 1 - pravo, 2 - desno


public:
    explicit SkiSanta(QObject *parent = nullptr);

signals:

};

#endif // SKISANTA_H
