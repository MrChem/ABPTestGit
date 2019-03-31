var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('WENTE');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);