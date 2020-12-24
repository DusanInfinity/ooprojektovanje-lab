#include "myview.h"
#include <QPainter>
#include <QImage>
#include <QTimer>

MyView::MyView(QWidget *parent) : QWidget(parent)
{
    mx=0;
    my=0;
    tick=0;

    this->img = QPixmap(500, 500).toImage();
    QPainter pImg(&img);
    pImg.setBrush(Qt::white);
    pImg.drawRect(0,0,500,500);
    pImg.setBrush(QColor(205,133,63));
    pImg.drawRect(250-25,500-100,50,100);

    QTimer *timer = new QTimer(this);
    connect(timer, SIGNAL(timeout()), this, SLOT(updateImage()));
    timer->start(2); //Bilo: timer->start(2020); Ovu liniju ne moramo da menjamo, u slucaju da smo dovoljno strpljivi :D

}

void MyView::paintEvent(QPaintEvent *)
{    
    QPainter p(this);
    p.drawImage(0,0,img);
}

int MyView::rollqrand()
{
    return tick%3; // Problem je sto ce ova funkcija uvek da vraca sekvencu brojeva 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2...
}

int MyView::getRandomRoll()
{
    return qrand()%6; // Ranije bilo: return rollqrand()%6; -> problem nastaje jer se redom biraju indeksi, ne postoji sansa da se izabere 0 pa recimo 2, pa 1 itd.
}

void MyView::updateImage()
{
    QPainter pImg(&img);
    QPoint pts[6]={{100,400},{400,400},{250,50},{100,400},{400,400},{250,50}};

    int roll=getRandomRoll();

    // izbor razlicitih indeksa zaredom(recimo nakon 0 ide 2, pa nakon 2 ide 1 itd.) nam je bitan zbog random generisanja vrednosti
    // nama ce uvek pts[roll].x() da vraca 100 pa 400 pa 250 i tako u krug, vrednosti ce krenuti da se ponavljaju i necemo kasnije
    // dobijati random vrednosti za x >= 100 && x <= 400, kao i za y >= 50 && y <= 400 (Dokaz je u komentarima ispod)
    // Medjutim, sa qrand() to nece biti slucaj, dobicemo daleko veci broj kombinacija koordinata tacaka koje ce formirati jelku(sacinjenu od trouglova)
    mx=(mx+pts[roll].x())/2;
    my=(my+pts[roll].y())/2;

    // (roll 0)u 1. krugu x = 100, y = 400
    // (roll 1)2. krug x = (100+400)/2 = 250, y = (400+400)/2 = 400
    // (roll 2)3. krug x = (250+250)/2 = 250, y = (400+50)/2 = 225
    // (roll 0)4. krug x = (250+100)/2 = 175, y = (225+400)/2 = 312
    // (roll 1)5. krug x = (175+400)/2 = 337, y = (312+400)/2 = 356
    // (roll 2)6. krug x = (337+250)/2 = 293, y = (356+50)/2 = 203
    // (roll 0)7. krug x = (293+100)/2 = 196, y = (203+400)/2 = 301
    // (roll 1)8. krug x = (196+400)/2 = 298, y = (301+400)/2 = 350
    // (roll 2)9. krug x = (298+250)/2 = 274, y = (350+50)/2 = 200
    // (roll 0)10. krug x = (274+100)/2 = 187, y = (200+400)/2 = 300
    // (roll 1)11. krug x = (187+400)/2 = 293, y = (300+400)/2 = 350
    // (roll 2)12. krug x = (293+250)/2 = 271, y = (350+50)/2 = 200
    // (roll 0)13. krug x = (271+100)/2 = 185, y = (200+400)/2 = 300
    // (roll 1)14. krug x = (185+400)/2 = 292, y = (300+400)/2 = 350
    // (roll 2)15. krug x = (292+250)/2 = 271, y = (350+50)/2 = 200
    // (roll 0)16. krug x = (271+100)/2 = 185, y = (200+400)/2 = 300
    // (roll 1)17. krug x = (185+400)/2 = 292, y = (300+400)/2 = 350
    // (roll 2)18. krug x = (292+250)/2 = 271, y = (350+50)/2 = 200

    // Primecujemo da ce sekvenca od 12. do 14. kruga({271, 200}, {185, 300}, {292, 350}) stalno da se ponavlja

    pImg.setPen(QColor(0,200,0));
    pImg.drawPoint(mx,my);

    tick++;
    this->repaint();
}
