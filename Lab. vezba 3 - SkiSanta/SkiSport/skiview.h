#ifndef SKIVIEW_H
#define SKIVIEW_H

#include <QWidget>
#include <QTimer>
#include "skigame.h"

class SkiView : public QWidget
{
    Q_OBJECT

    SkiGame *game;
    QTimer *timer;

public:
    explicit SkiView(QWidget *parent = nullptr);
    void paintEvent(QPaintEvent*);
    void keyPressEvent(QKeyEvent*);


signals:

public slots:
    void tick();

};

#endif // SKIVIEW_H
