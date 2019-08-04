/** 生成一个饼图 */
/** @parm element HTMLElement元素 */
function createPie(title, subTitle, element, seriesName, seriesData) {
    var myChart = echarts.init(element);
    var kindsData = []
    seriesData.forEach(d => {
        kindsData.push(d.name)
    })
    let seriesPie = createPieSeries(seriesName, seriesData)

    let option = {
        title: {
            text: title,
            subtext: subTitle,
            x: 'center'
        },
        tooltip: {
            trigger: 'item',
            formatter: "{a} <br/>{b} : {c} ({d}%)"
        },
        legend: {
            orient: 'vertical',
            left: 'left',
            data: kindsData
        },
        series: [seriesPie]
    };

    myChart.setOption(option);
}
/**@param dataV 是一个对象数组 其中每个对象含有 name value两个属性 */
function createPieSeries(name, dataV) {
    return {
        name: name,
        type: 'pie',
        radius: '55%',
        center: ['50%', '60%'],
        data: dataV,
        itemStyle: {
            emphasis: {
                shadowBlur: 10,
                shadowOffsetX: 0,
                shadowColor: 'rgba(0, 0, 0, 0.5)'
            }
        }
    }
}

/** 生成折线图 */
function createLine(title, element, seriesData, xData) {
    var myChart = echarts.init(element);

    let legendData = []
    let seriesInnerData = []
    seriesData.forEach(e => {
        legendData.push(e.name)
        seriesInnerData.push({
            name: e.name,
            type: 'line',
            smooth: true,
            stack: '总量',
            areaStyle: {},
            data: e.data
        })
    })

    // 指定图表的配置项和数据
    let option = {
        title: {
            text: title
        },
        tooltip: {
            trigger: 'axis',
            axisPointer: {
                type: 'cross',
                label: {
                    backgroundColor: '#6a7985'
                }
            }
        },
        legend: {
            data: legendData
        },
        toolbox: {
            feature: {
                saveAsImage: {}
            }
        },
        grid: {
            left: '3%',
            right: '4%',
            bottom: '3%',
            containLabel: true
        },
        xAxis: [
            {
                type: 'category',
                boundaryGap: false,
                data: xData
            }
        ],
        yAxis: [
            {
                type: 'value'
            }
        ],
        series: seriesInnerData
    };


    // 使用刚指定的配置项和数据显示图表。
    myChart.setOption(option);
}

function getSmallChartGraphic(top,text,font,color){
    let gra = { //设置图内部文字
                type: 'text',
                left: 'center', //设置偏移量
                top: top,
                z: 2,
                zlevel: 100,
                style: {
                    text: text,
                    x: 0,
                    y: 0,
                    textAlign: 'center',
                    fill: color,
                    width: 200,
                    height: 200,
                    textFont: font
                }
            }
    return gra
}

function createSmallLineGraph(innerGraphText,element,seriesName,xyData,color = 'rgb(134,220,236,0.5)') {
    //'rgb(134,220,236,0.5)'
    let font_family = '-apple-system,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif,"Apple Color Emoji","Segoe UI Emoji","Segoe UI Symbol","Noto Color Emoji"'

    let graList = []
    graList.push({ top: '15%', text: innerGraphText[0], font: '13px ' + font_family, color: '#818ea3' })
    graList.push({ top: 'center', text: innerGraphText[1], font: '2rem ' + font_family, color: '#3d5170' })
    graList.push({ top: '70%', text: innerGraphText[2], font: '14px ' + font_family, color: '#3ac671' })

    let xData = []
    xyData.forEach(e=>{
        xData.push(e.x)
    })
    let yData = []
    xyData.forEach(e=>{
        yData.push(e.y)
    })

    var myChart = echarts.init(element);

    let option = {
        tooltip: {
            trigger: 'axis',
            axisPointer: {
                type: 'cross',
                label: {
                    backgroundColor: '#6a7985'
                }
            }
        },
        color: color,
        graphic: graList.map(e => getSmallChartGraphic(e.top, e.text, e.font, e.color)),
        grid: {
            left: '0%',
            right: '0%',
            bottom: '-5%'
        },
        xAxis: [
            {
                show: false,
                type: 'category',
                boundaryGap: false,
                data: xData
            }
        ],
        yAxis: [
            {
                type: 'value',
                show: false
            }
        ],
        series: [
            {
                smooth: true,
                name: seriesName,
                type: 'line',
                stack: '总量',
                areaStyle: {},
                data: yData
            },
        ]
    };
    myChart.setOption(option);
}