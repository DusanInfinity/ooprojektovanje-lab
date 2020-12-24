#include "skisanta.h"
#include <QDebug>

SkiSanta::SkiSanta(int w, int h, QObject *parent) : QObject(parent)
{
    x = w/4;
    y = h/4;
    this->h = h;
    this->w = w;
    currentState = 1; // 0 - levo, 1 - pravo, 2 - desno
    imageState = 0;

    QImage imageL1, imageL2, imageS1, imageS2, imageR1, imageR2;
    imageL1.load(":/images/images/santa-left1.png");
    imageL2.load(":/images/images/santa-left2.png");
    imageS1.load(":/images/images/santa1.png");
    imageS2.load(":/images/images/santa2.png");
    imageR1.load(":/images/images/santa-right1.png");
    imageR2.load(":/images/images/santa-right2.png");
    images = {imageL1, imageL2, imageS1, imageS2, imageR1, imageR2};
}

void SkiSanta::changeSantaPos(int value)
{
    if(x+value < 0 || x + value > w-w/7) return;

    if(value < 0)
        currentState = 0;
    else if(value > 0)
        currentState = 2;
    else
        currentState = 1;

    //qDebug() << "changeSantaPos:" << value;

    x += value;
}


void SkiSanta::resize(QSize newSize)
{
    if(w == newSize.width() || h == newSize.height()) return;
    qDebug() << "resize";
    x = (int)(((float)newSize.width()/w)*x);
    y = (int)(((float)newSize.height()/h)*y);

    this->w = newSize.width();
    this->h = newSize.height();
}

int SkiSanta::getX() const
{
    return x;
}

int SkiSanta::getY() const
{
    return y;
}

void SkiSanta::changeImage()
{
    imageState = (imageState + 1) % 2;
}

QImage SkiSanta::getCurrentStateImage()
{
    return images[2*currentState + imageState];
}
