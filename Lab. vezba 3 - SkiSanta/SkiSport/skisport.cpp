#include "skisport.h"
#include "ui_skisport.h"

SkiSport::SkiSport(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::SkiSport)
{
    ui->setupUi(this);
}

SkiSport::~SkiSport()
{
    delete ui;
}

