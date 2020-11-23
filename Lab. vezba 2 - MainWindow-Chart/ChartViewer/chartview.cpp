#include "chartview.h"
#include <QPainter>
#include <QMessageBox>
#include <QMouseEvent>
#include "chartpointdialog.h"
#include <QDebug>
#include <QDialog>

ChartView::ChartView(QWidget *parent) : QWidget(parent)
{
    BrPodataka = 0;
}

void ChartView::paintEvent(QPaintEvent *)
{
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

    if(m_chartDocRef != nullptr)
    {
        QList<ChartPoint*> points = m_chartDocRef->getPoints();
        BrPodataka = points.length();
        qDebug() << "paintEvent triggerovan!";
        if(BrPodataka > 0)
        {
            int korakSirina = (width()-200)/BrPodataka;
            for(int i = 0; i < BrPodataka; i++)
            {
                int x = 100 + i*korakSirina;
                p.setBrush(points[i]->getColor());
                p.drawRect(100 + i*korakSirina, height()-50, korakSirina-10, -(points[i]->getValue()/10*korakVisina));
                p.drawText(x+korakSirina/3, height()-30, points[i]->getLabel());
            }
        }
    }
}

void ChartView::setChartDocRef(ChartDoc *p)
{
    m_chartDocRef = p;
}

void ChartView::onChartDataChanged()
{
    //QMessageBox::information(this, "Obavestenje", "Event je triggerovan!");
}


void ChartView::mouseDoubleClickEvent( QMouseEvent * e )
{
    if ( e->button() == Qt::LeftButton )
    {
        qDebug() << "Dupli klik detektovan!";
        if(BrPodataka > 0)
        {
            QList<ChartPoint*> points = m_chartDocRef->getPoints();
            int korakVisina = (height()-50-50)/10;
            int korakSirina = (width()-200)/BrPodataka;
            for(int i = 0; i < BrPodataka; i++) // Detektujemo da li je korisnik kliknuo na neki od stubova u grafikonu
            {
                QPoint poz = e->pos();
                if(poz.x() >= 100 + i*korakSirina && poz.x() <= 100 + i*korakSirina + korakSirina-10)
                {
                    qDebug() << "Sirina odgovarajuca za stub " << i;
                    if(poz.y() >= height()-50-(points[i]->getValue()/10*korakVisina) && poz.y() <= height()-50)
                    {
                        qDebug() << "Visina odgovarajuca za stub " << i;
                        ChartPointDialog dialog;
                        dialog.setData(points[i]->getLabel(), points[i]->getValue(), points[i]->getColor());
                        if(dialog.exec() == QDialog::Accepted)
                        {
                            m_chartDocRef->updatePointData(i, dialog.getLabel(), dialog.getValue(), dialog.getColor());
                        }
                        break;
                    }
                }

            }
        }
    }
}
