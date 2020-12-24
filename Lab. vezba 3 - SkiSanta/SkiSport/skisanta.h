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
    QList<QImage> images;
    short currentState; // 0 - levo, 1 - pravo, 2 - desno
    short imageState;


public:
    explicit SkiSanta(int w, int h, QObject *parent = nullptr);
    void changeSantaPos(int);

    int getX() const;
    int getY() const;
    QImage getCurrentStateImage();
    void changeImage();
    void resize(QSize);

signals:

};

#endif // SKISANTA_H
