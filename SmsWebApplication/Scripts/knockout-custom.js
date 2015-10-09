// для даты и времени
(function () {
    // Возвращает дату в виде объекта Date
    function datePart(observable) {
        return moment(ko.utils.unwrapObservable(observable)).startOf('day').toDate();
    }

    // Возвращает время в виде строки в формате HH:mm
    function timePart(observable) {
        return moment(ko.utils.unwrapObservable(observable)).format('HH:mm');
    }

    var timeSplit = /(\d{1,2})\:(\d{1,2})/;

    // Возвращает строку, содержащую дату и время
    function dateTimeString(date, time) {
        var h = 0, m = 0;
        var match = timeSplit.exec(time);
        if (match) {
            h = match[1];
            m = match[2];
        }
        return moment(new Date(date.getFullYear(), date.getMonth(), date.getDate(), h, m, 0)).format("YYYY-MM-DD[T]HH:mm:ss");
    }

    // Биндинг привязывает текстбокс+datepicker к строке
    // Строка разбивается на две части - дату и время
    // Данный биндинг читает/изменяет только дату
    ko.bindingHandlers.localDatepicker = {
        init: function (element, valueAccessor, allBindingsAccessor) {
            var options = allBindingsAccessor().datepickerOptions || { changeMonth: true },
                $el = $(element);

            //initialize datepicker with some optional options
            $el.datepicker(options);
            //$el.datepicker("setDate", datePart(valueAccessor()));

            //обновить строку при изменении данных в текстбоксе
            ko.utils.registerEventHandler(element, "change", function () {
                var observable = valueAccessor();

                var date = $el.datepicker("getDate");
                var time = timePart(observable);

                var result = dateTimeString(date, time);

                observable(result);
            });

            //handle disposal (if KO removes by the template binding)
            ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
                $el.datepicker("destroy");

            });

        },

        // обновить значение текстбокса если кто-то изменил поле извне
        update: function (element, valueAccessor) {
            var val = datePart(valueAccessor());
            var $el = $(element);
            var current = $el.datepicker("getDate");

            if (val - current !== 0) {
                $el.datepicker("setDate", val);
            }
        }
    };

    // Биндинг привязывает текстбокс+timepicker к строке
    // Строка разбивается на две части - дату и время
    // Данный биндинг читает/изменяет только время
    ko.bindingHandlers.localTimepicker = {
        init: function (element, valueAccessor, allBindingsAccessor) {
            var options = allBindingsAccessor().timepickerOptions || { showPeriodLabels: false, hourText: 'Часы', minuteText: 'Минуты', },
                $el = $(element);

            //initialize datepicker with some optional options
            $el.timepicker(options);
            //$el.timepicker("setTime", timePart(valueAccessor()));

            //обновить строку при изменении данных в текстбоксе
            ko.utils.registerEventHandler(element, "change", function () {
                var observable = valueAccessor();

                var date = datePart(observable);
                var time = $el.timepicker("getTime");

                var result = dateTimeString(date, time);

                observable(result);
            });

            //handle disposal (if KO removes by the template binding)
            ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
                $el.timepicker("destroy");

            });

        },

        // обновить значение текстбокса если кто-то изменил поле извне
        update: function (element, valueAccessor) {
            var val = timePart(valueAccessor());
            var $el = $(element);

            $el.timepicker("setTime", val);
        }
    };
})();