const canvas = document.querySelector("canvas")
const ctx = canvas.getContext("2d")

canvas.width = 671
canvas.height = 525

let focalLength = 6
const updateFocal = (event) => {
    focalLength = 6 * event.srcElement.value / 1000
}

const F = 5
const B = 7

const meshes = {
    // 8 vertices of a cube. [x, y, z]
    cube: [
        // 1   2
        //   F
        // 3   4
        // 1   2
        //   B
        // 3   4

        {
            x: .25,
            y: .25,
            z: F,
        },
        {
            x: .75,
            y: .25,
            z: F,
        },
        {
            x: .25,
            y: .75,
            z: F,
        },
        {
            x: .75,
            y: .75,
            z: F,
        },

        {
            x: .25,
            y: .25,
            z: B,
        },
        {
            x: .75,
            y: .25,
            z: B,
        },
        {
            x: .25,
            y: .75,
            z: B,
        },
        {
            x: .75,
            y: .75,
            z: B,
        },
    ]
}

let renders = {
    cube: []
}

const project = (vertex) => {
    const x = focalLength * (vertex.x / vertex.z)
    const y = focalLength * (vertex.y / vertex.z)
    return {
        x: x,
        y: y,
    }
}

const scale = (point) => {
    return {
        x: point.x * canvas.width,
        y: point.y * canvas.height,
    }
}

ctx.lineWidth = 3
const lineBetween = (point1, point2) => {
    ctx.beginPath()
    ctx.moveTo(point1.x, point1.y)
    ctx.lineTo(point2.x, point2.y)
    ctx.stroke()
    ctx.closePath()
}

meshes.cube.forEach(vertex => {
    point = scale(project(vertex))
    const x = point.x
    const y = point.y

    renders.cube.push({
        x: x,
        y: y,
    })
})

const frame = () => {
    ctx.clearRect(0, 0, canvas.width, canvas.height)

    meshes.cube.forEach(vertex => {
        point = scale(project(vertex))
        const x = point.x
        const y = point.y

        ctx.beginPath()
        ctx.arc(x, y, 10, 0, Math.PI * 2)
        ctx.stroke()
        ctx.closePath()
    })

    for (let index = 0; index < renders.cube.length; index++) {
        renders.cube[index] = {
            x: scale(project(meshes.cube[index])).x,
            y: scale(project(meshes.cube[index])).y,
        }
    }

    lineBetween(renders.cube[0], renders.cube[1])
    lineBetween(renders.cube[3], renders.cube[2])
    lineBetween(renders.cube[3], renders.cube[1])
    lineBetween(renders.cube[2], renders.cube[0])

    lineBetween(renders.cube[0 + 4], renders.cube[1 + 4])
    lineBetween(renders.cube[3 + 4], renders.cube[2 + 4])
    lineBetween(renders.cube[3 + 4], renders.cube[1 + 4])
    lineBetween(renders.cube[2 + 4], renders.cube[0 + 4])

    lineBetween(renders.cube[0 + 4], renders.cube[0])
    lineBetween(renders.cube[1 + 4], renders.cube[1])
    lineBetween(renders.cube[2 + 4], renders.cube[2])
    lineBetween(renders.cube[3 + 4], renders.cube[3])

    window.requestAnimationFrame(frame)
}

window.requestAnimationFrame(frame)