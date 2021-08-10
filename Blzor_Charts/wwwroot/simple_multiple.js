//function generateChart(a, b, c, d, e, f, g) {

function generateLineChart([]) {
    let data = [];
    
    alert(JSON.stringify(arguments));
    data = arguments;
    var chart1 = c3.generate({
        bindto: '#chart1',
        data: {
            columns: [
                data
            ]
        }
    });
}

function generateBarChart([]) {
    let data = [];

    alert(JSON.stringify(arguments));
    data = arguments;
    var chart = c3.generate({
        bindto: '#chart2',
        data: {
            columns: [
               data
            ],
            type: 'bar'
        },
        bar: {
            width: {
                ratio: 0.5  
            }
           
        }
    });
}

 