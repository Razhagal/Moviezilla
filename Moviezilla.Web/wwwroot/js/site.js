document.addEventListener("DOMContentLoaded", onPageLoaded);

function onPageLoaded() {
    const mainNavSearchBox = document.querySelector('#headerSearchContainer');
    const mainNavSearchToggle = document.querySelector('#headerSearchToggle');
    const mainNavSearchInput = document.querySelector('#headerSearchInput');
    
    mainNavSearchToggle.addEventListener('click', onMainNavToggleClick);
    document.addEventListener("click", onClickOutsideMainNavSearch);
    
    function onMainNavToggleClick(e) {
        mainNavSearchBox.classList.toggle('expanded');
        if (mainNavSearchBox.classList.contains('expanded')) {
            setTimeout(() => mainNavSearchInput.focus(), 150);
        }
    }
    
    function onClickOutsideMainNavSearch(e) {
        if (!mainNavSearchBox.contains(e.target) && !mainNavSearchInput.value.trim()) {
            mainNavSearchBox.classList.remove('expanded');
        }
    }
}