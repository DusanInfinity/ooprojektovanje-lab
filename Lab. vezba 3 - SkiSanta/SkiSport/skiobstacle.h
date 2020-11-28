#ifndef SKIOBSTACLE_H
#define SKIOBSTACLE_H

#include <QObject>

class SkiObstacle : public QObject
{
    Q_OBJECT

    int x;
    int y;
    int w;
    int h;
    QImage *image;

public:
    explicit SkiObstacle(QObject *parent = nullptr);

signals:

};

#endif // SKIOBSTACLE_H
