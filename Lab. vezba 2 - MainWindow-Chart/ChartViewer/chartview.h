#ifndef CHARTVIEW_H
#define CHARTVIEW_H

#include <QWidget>
#include "chartdoc.h"

class ChartView : public QWidget
{
    Q_OBJECT
    ChartDoc *m_chartDocRef;
    int BrPodataka;
    void mouseDoubleClickEvent( QMouseEvent * e );

public:
    explicit ChartView(QWidget *parent = nullptr);
    void paintEvent(QPaintEvent*);
    void setChartDocRef(ChartDoc*);
    void DrawSingleBar(QPainter &p, int, float, QColor);


signals:

public slots:
    void onChartDataChanged();


};

#endif // CHARTVIEW_H
