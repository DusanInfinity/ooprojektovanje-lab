#ifndef SKIOBSTACLE_H
#define SKIOBSTACLE_H

#include <QObject>
#include <QImage>

class SkiObstacle : public QObject
{
    Q_OBJECT

    int x;
    int y;
    int w;
    int h;
    QImage image;

public:
    explicit SkiObstacle(int w, int h, QObject *parent = nullptr, int currentX = 0, int currentY = 0);

    QImage getImage() const;

    void reduceY(int value);

    int getX() const;

    int getY() const;
    void resize(QSize);

signals:

};

#endif // SKIOBSTACLE_H
