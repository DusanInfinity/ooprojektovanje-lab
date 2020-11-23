#include "chartpoint.h"

ChartPoint::ChartPoint()
{
    this->label = "UNDEF";
    this->value = 0;
    this->color = "#000000";
}

ChartPoint::ChartPoint(QString l, float v, QColor c)
{
    this->label = l;
    this->value = v;
    this->color = c;
}


QString ChartPoint::getChartData()
{
    return label + "," + QString::number(value) + "," + color.name();
}

QString ChartPoint::getLabel()
{
    return label;
}

float ChartPoint::getValue()
{
    return value;
}

QColor ChartPoint::getColor()
{
    return color;
}

void ChartPoint::updateData(QString l, float v, QColor c)
{
    label = l;
    value = v;
    color = c;
}
