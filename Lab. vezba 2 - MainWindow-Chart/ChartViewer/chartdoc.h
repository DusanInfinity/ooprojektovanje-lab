#ifndef CHARTDOC_H
#define CHARTDOC_H

#include <QObject>
#include "chartpoint.h"

class ChartDoc : public QObject
{
    Q_OBJECT

    QList<ChartPoint*> m_points;

public:
    explicit ChartDoc(QObject *parent = nullptr);
    ~ChartDoc();
    void loadChartFromFile(QString file);
    void saveChartToFile(QString file);


signals:
    void chartDataChanged(QString data);

};

#endif // CHARTDOC_H
