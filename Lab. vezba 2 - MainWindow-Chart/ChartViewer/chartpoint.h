#ifndef CHARTPOINT_H
#define CHARTPOINT_H

#include <QString>
#include <QColor>


class ChartPoint
{
    QString label;
    float value;
    QColor color;
public:
    ChartPoint();
    ChartPoint(QString l, float v, QColor c);
    QString getChartData();
    QString getLabel();
    float getValue();
    QColor getColor();
    void updateData(QString l, float v, QColor c);
};

#endif // CHARTPOINT_H
