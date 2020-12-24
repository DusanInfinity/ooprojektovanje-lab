#include "skiview.h"
#include <QPainter>
#include <QTimer>
#include <QDebug>
#include <QKeyEvent>

SkiView::SkiView(QWidget *parent) : QWidget(parent)
{
    qDebug() << "SkiView" << "w:" << parent->width() << "h:" << parent->height();
    game = new SkiGame(this, parent->width(), parent->height());
    timer = new QTimer(this);
    connect(timer, SIGNAL(timeout()), this, SLOT(tick()));
    timer->start(75);
}


void SkiView::paintEvent(QPaintEvent *)
{
    QPainter p(this);
    game->draw(p, width(), height());
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
        default:
        {
            QWidget::keyPressEvent(event);
        }
    }
}

void SkiView::keyReleaseEvent(QKeyEvent *event)
{
    switch(event->key())
    {
        case Qt::Key_Left:
        case Qt::Key_Right:
        {
            game->moveSanta(0);
            break;
        }
        default:
        {
            QWidget::keyReleaseEvent(event);
        }
    }
}

void SkiView::resizeEvent(QResizeEvent *event)
{
    game->resize(event->size());
}

void SkiView::tick()
{
    game->tick();
    repaint();
}
