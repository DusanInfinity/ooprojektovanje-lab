#include "skiobstacle.h"
#include <QDebug>

int SkiObstacle::getX() const
{
    return x;
}

int SkiObstacle::getY() const
{
    return y;
}

SkiObstacle::SkiObstacle(int w, int h, QObject *parent, int currentX, int currentY) : QObject(parent)
{
    x = currentX;
    y = currentY;

    this->w = w;
    this->h = h;

    if(qrand() % 2 == 0)
        image.load(":/images/images/snowman.png");
    else
        image.load(":/images/images/tree.png");
}


QImage SkiObstacle::getImage() const
{
    return image;
}


void SkiObstacle::reduceY(int value)
{
    y -= value;

    if(y < -w/7) // kada se vise ne vidi na ekranu
    {
        x = qrand() % (w-w/7);
        y = h + h/7 + 50;
    }
}

void SkiObstacle::resize(QSize newSize)
{
    if(w == newSize.width() || h == newSize.height()) return;
    qDebug() << "resize";
    x = (int)(((float)newSize.width()/w)*x);
    y = (int)(((float)newSize.height()/h)*y);

    this->w = newSize.width();
    this->h = newSize.height();
}
