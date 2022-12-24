let box1 = document.getElementById("box-1")
let box2 = document.getElementById("box-2")
let box3 = document.getElementById("box-3")

let baseUrl = window.location.href

const box1ClickHandler = async () => {
    let data = {
        Selection: "1"
    }
    
    let response = await fetch(`${baseUrl}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify(data)
    })

    if (response.redirected) window.location.replace(response.url)
}
const box2ClickHandler = async () => {
    let data = {
        Selection: "2"
    }
    
    let response = await fetch(`${baseUrl}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify(data)
    })

    if (response.redirected) window.location.replace(response.url)
}
const box3ClickHandler = async () => {
    let data = {
        Selection: "3"
    }
    
    let response = await fetch(`${baseUrl}`, {
        method: 'POST',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify(data)
    })

    if (response.redirected) window.location.replace(response.url)
}
box1.addEventListener("click", box1ClickHandler)
box2.addEventListener("click", box2ClickHandler)
box3.addEventListener("click", box3ClickHandler)