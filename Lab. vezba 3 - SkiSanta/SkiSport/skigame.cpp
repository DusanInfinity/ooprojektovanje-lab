#include "skigame.h"
#include <QPainter>
#include <QDebug>

void SkiGame::createObstacles(int w, int h)
{
    qDebug() << "createObstacles" << "w:" << w << "h:" << h;
    int yCoord = h;
    int i = 0;
    while(i < brPrepreka)
    {
        int brPreprekaURedu = qrand() %4 + 1;
        for(int j = 0; j < brPreprekaURedu && i < brPrepreka; j++, i++)
        {
            obstacles[i] = new SkiObstacle(w, h, this, qrand() % (w-w/7), yCoord);
        }

        yCoord += qrand()% 70 + h/7;
    }
}

SkiGame::SkiGame(QObject *parent, int w, int h) : QObject(parent)
{
    santaScore = 0;
    brzinaIgre = 6;
    brPrepreka = 20;
    santa = new SkiSanta(w, h, this);

    obstacles = new SkiObstacle*[brPrepreka];

    createObstacles(w, h);
}
SkiGame::~SkiGame()
{
    delete[] obstacles; // brisanje pointera na listu
}

void SkiGame::draw(QPainter &p, int w, int h)
{
    // Crtanje deda mraza
    QImage image = santa->getCurrentStateImage();
    p.drawImage(santa->getX(), santa->getY(), image.scaled(w/7, h/7));

    // Crtanje prepreka
    for(int i = 0; i < brPrepreka; i++)
    {
        p.drawImage(obstacles[i]->getX(), obstacles[i]->getY(), obstacles[i]->getImage().scaled(w/7, h/7));
    }

    // Skor
    p.setBrush(Qt::red);
    int scoreWidth = 90 + brojCifara(santaScore)*15;
    p.drawRect(0, 0, scoreWidth, 30);
    QFont font;
    font.setPixelSize(25);
    p.setFont(font);
    p.setPen(Qt::white);
    p.drawText(5, 25, "Score: " + QString::number(santaScore));
}

int SkiGame::brojCifara(int num)
{
    int tmp = num;
    int br = 0;
    while(tmp > 0)
    {
        br++;
        tmp /= 10;
    }
    return br;
}

void SkiGame::moveSanta(int value)
{
    //qDebug() << "moveSanta:" << value;
    santa->changeSantaPos(value * (brzinaIgre + brzinaIgre/2));
}

void SkiGame::tick()
{
    for(int i = 0; i < brPrepreka; i++)
    {
        obstacles[i]->reduceY(brzinaIgre);
    }
    santaScore += brzinaIgre;

    santa->changeImage();
}

void SkiGame::resize(QSize newSize)
{
    santa->resize(newSize);
    for(int i = 0; i < brPrepreka; i++)
    {
        obstacles[i]->resize(newSize);
    }
}
