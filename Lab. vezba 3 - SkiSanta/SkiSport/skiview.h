#ifndef SKIVIEW_H
#define SKIVIEW_H

#include <QWidget>
#include <QTimer>
#include "skigame.h"
#include <QtGui>

class SkiView : public QWidget
{
    Q_OBJECT

    SkiGame *game;
    QTimer *timer;

public:
    explicit SkiView(QWidget *parent = nullptr);
    void paintEvent(QPaintEvent*);
    void keyPressEvent(QKeyEvent *event);
    void keyReleaseEvent(QKeyEvent *event);
    void resizeEvent(QResizeEvent *event);

signals:

public slots:
    void tick();

};

#endif // SKIVIEW_H
