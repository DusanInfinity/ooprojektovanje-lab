#ifndef SKIGAME_H
#define SKIGAME_H

#include <QObject>
#include "skisanta.h"

class SkiGame : public QObject
{
    Q_OBJECT

    SkiObstacle *obstacles;
    SkiSanta *santa;

public:
    explicit SkiGame(QObject *parent = nullptr);
    void draw();
    void moveSanta(int);
    void tick();

signals:

};

#endif // SKIGAME_H
