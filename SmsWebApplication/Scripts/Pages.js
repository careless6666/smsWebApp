var smsModule = new function () { }

smsModule.Menu = new function () { }

smsModule.Menu.Init = function () {
    function hideAllItems() {
        $('.s-menu-item-value').hide();
        $('#main-page').hide();
    }
    
    function showSelected(element) {
        hideAllItems();
        var act = $(element).attr("data-action");

        for (var i = 0; i < $('.s-menu-item-value').length; i++) {
            if(($($('.s-menu-item-value')[i])).attr("data-action") === act) {
                $($('.s-menu-item-value')[i]).show();
                return;
            }
        }
        hideAllItems();
        $('#main-page').show();
    }

    $('.s-menu').click(function () {
        showSelected(this);
    });
}

smsModule.Init = function() {
    smsModule.Menu.Init();
    smsModule.ControlsInitialization();

}

smsModule.ControlsInitialization = function() {
    $("#DoNotSendSmsAddToOrder").bootstrapToggle({ on: 'Да', off: 'Нет' });
    $("#TranslitAddToOrder").bootstrapToggle({ on: 'Да', off: 'Нет' });

    
}

    






