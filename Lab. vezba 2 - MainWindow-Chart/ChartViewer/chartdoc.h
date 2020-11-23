#ifndef CHARTDOC_H
#define CHARTDOC_H

#include <QObject>
#include "chartpoint.h"

class ChartDoc : public QObject
{
    Q_OBJECT

    QList<ChartPoint*> m_points;

    void deleteCurrentChartData();

public:
    explicit ChartDoc(QObject *parent = nullptr);
    ~ChartDoc();
    void loadChartFromFile(QString file);
    void saveChartToFile(QString file);
    QList<ChartPoint*> getPoints();
    void updatePointData(int, QString, QString, QString);


signals:
    void chartDataChanged();

};

#endif // CHARTDOC_H
