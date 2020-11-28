#include "skiview.h"
#include <QPainter>
#include <QKeyEvent>
#include <QTimer>

SkiView::SkiView(QWidget *parent) : QWidget(parent)
{
    game = new SkiGame(this);
    timer = new QTimer(this);
    connect(timer, SIGNAL(timeout()), this, SLOT(tick()));
    timer->start(100);
}


void SkiView::paintEvent(QPaintEvent *)
{
    game->draw();

    QPainter p(this);
    p.setBrush(Qt::white);
    p.drawRect(0, 0, width(), height());

    p.setBrush(Qt::black);
    p.drawLine(100, 50, 100, height()-50); // Y osa
    p.drawLine(100, height()-50, width()-100, height()-50); // X osa

    int korakVisina = (height()-50-50)/10;
    for(int i = 0; i <= 10; i++)
    {
        p.drawText(70, height()-50-i*korakVisina, QString::number(i*10)); // Podeoci
        p.drawLine(95, height()-50-i*korakVisina, 100, height()-50-i*korakVisina); // Crte kod podeoka
    }
}


void SkiView::keyPressEvent(QKeyEvent *event)
{
    switch(event->key())
    {
        case Qt::Key_Left:
        {
            game->moveSanta(-1);
            break;
        }
        case Qt::Key_Right:
        {
            game->moveSanta(1);
            break;
        }
    }
}

void SkiView::tick()
{
    game->tick();
}
