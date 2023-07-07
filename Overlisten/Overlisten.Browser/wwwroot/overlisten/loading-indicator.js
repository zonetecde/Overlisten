function onResourceLoaded(resourceIndex, totalResourceCount) {
    let percentage = document.getElementById("loading-indicator-percentage");
    if (percentage) {
        percentage.style.marginTop = "5.25em";
        percentage.innerHTML = Math.round((resourceIndex / totalResourceCount) * 100) + "%";
        document.getElementById("main-progressBar").value = ((resourceIndex / totalResourceCount) * 100);
    }
}

let loadingIndicatorWrapper = document.createElement("div");
loadingIndicatorWrapper.classList.add("loading-indicator-wrapper");
document.getElementById("app").appendChild(loadingIndicatorWrapper);

let loadingIndicator = document.createElement("div");
loadingIndicator.classList.add("loading-indicator");
loadingIndicatorWrapper.appendChild(loadingIndicator);

let loadingIndicatorPercentageContainer = document.createElement("div");
loadingIndicatorPercentageContainer.classList.add("loading-indicator-percentage-container");
loadingIndicator.appendChild(loadingIndicatorPercentageContainer);

let loadingIndicatorPercentage = document.createElement("div");
loadingIndicatorPercentage.id = "loading-indicator-percentage";
loadingIndicatorPercentageContainer.appendChild(loadingIndicatorPercentage);