using DeviceControl;
using MeasuringDevice;
using System;

internal class MeasureMassDevice : MeasureDataDevice
{
    public override decimal ImperialValue()
    {
        if (unitsToUse == Units.Imperial)
        {
            return mostRecentMeasure;
        }
        else return mostRecentMeasure * 0.4536m;
    }

    public override decimal MetricValue()
    {
        if (unitsToUse == Units.Metric)
        {
            return mostRecentMeasure;
        }
        else return mostRecentMeasure * 2.2046m;
    }

    public MeasureMassDevice(Units units)
    {
        unitsToUse = units;
        measurementType = DeviceType.MASS;
    }


}