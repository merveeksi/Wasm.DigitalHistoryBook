function addResizeEvent(dotnetRef) {
    window.addEventListener("resize", () => {
        dotnetRef.invokeMethodAsync("OnResize");
    });
}

function getBoundingClientRect(element) {
    return element.getBoundingClientRect();
}
function getBoundingClientRect(button) {
    return button.getBoundingClientRect();
}
