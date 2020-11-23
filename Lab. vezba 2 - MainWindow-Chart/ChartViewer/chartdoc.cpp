#include "chartdoc.h"
#include <QFile>
#include <QMessageBox>
#include <QDebug>

ChartDoc::ChartDoc(QObject *parent) : QObject(parent)
{

}

ChartDoc::~ChartDoc()
{
    /*
    foreach(ChartPoint *point, m_points)
    {
        delete point;
    } */
    deleteCurrentChartData();
}

void ChartDoc::deleteCurrentChartData()
{
    if(m_points.length() > 0)
    {
        qDeleteAll(m_points);
        m_points.clear();
    }
}

void ChartDoc::loadChartFromFile(QString fname)
{
    QFile f(fname);
    if(f.open(QFile::ReadOnly | QFile::Text))
    {
        deleteCurrentChartData();

        while(!f.atEnd())
        {
            QByteArray buff = f.readLine();
            QString data = QString::fromUtf8(buff.data(), buff.size());
            data.replace("\n", ""); // ovo radimo jer se prilikom izvrsavanja readLine funkcije cita i \n i dodaje u string, ovako ga uklanjamo jer nepotreban


            QStringList dataList = data.split(",");
            QString label = dataList[0];
            float value = dataList[1].toFloat();
            QColor color(dataList[2]);

            m_points.append(new ChartPoint(label, value, color));
        }
        f.close();
        emit chartDataChanged();
    }
    else
    {
        QMessageBox::critical(nullptr, "GRESKA", "Doslo je do greske prilikom otvaranja fajla:\n" + fname, QMessageBox::Ok);
    }
}

void ChartDoc::saveChartToFile(QString fname)
{
    QFile f(fname, this);
    if(f.open(QFile::WriteOnly | QFile::Text))
    {
        if(m_points.length() > 0)
        {
            foreach(ChartPoint *point, m_points)
            {
                QString text = point->getChartData();
                f.write(text.toUtf8() + "\n");
            }
        }

        f.close();
    }
    else
    {
        QMessageBox::critical(nullptr, "Greska", "Doslo je do greske prilikom otvaranja fajla:\n" + fname, QMessageBox::Ok);
    }
}

QList<ChartPoint*> ChartDoc::getPoints()
{
    return m_points;
}

void ChartDoc::updatePointData(int index, QString label, QString v, QString c)
{
    ChartPoint *point = m_points.at(index);

    bool succ = false;
    float value = v.toFloat(&succ);
    if(!succ) return;
    QColor color(c);
    if(!color.isValid()) return;
    point->updateData(label, value, color);
    qDebug() << "Uspesno azurirani podaci za tacku " << index;
    //emit chartDataChanged();
}
