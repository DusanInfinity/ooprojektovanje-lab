#ifndef SKIGAME_H
#define SKIGAME_H

#include <QObject>
#include "skisanta.h"
#include "skiobstacle.h"

class SkiGame : public QObject
{
    Q_OBJECT

    SkiObstacle **obstacles;
    SkiSanta *santa;
    int brPrepreka;
    int brzinaIgre;
    int santaScore;


    void createObstacles(int w, int h);
    int brojCifara(int);

public:
    explicit SkiGame(QObject *parent = nullptr, int w = 0, int h = 0);
    ~SkiGame();
    void draw(QPainter&, int, int);
    void moveSanta(int);
    void tick();
    void resize(QSize);

signals:

};

#endif // SKIGAME_H
