#include "chartdoc.h"

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

    qDeleteAll(m_points);
    m_points.clear();
}

void ChartDoc::loadChartFromFile(QString file)
{
 // TO-DO dovrsiti
}

void ChartDoc::saveChartToFile(QString file)
{
// TO-DO dovrsiti
}
