const canvas = document.querySelector("canvas")
const ctx = canvas.getContext("2d")

canvas.width = 671
canvas.height = 525

let focalLength = 1.2
const updateFocal = (event) => {
    focalLength = event.srcElement.value
}

const F = 5
const B = 6
const O = 1.75
const offset = 100

const baseMeshes = {
    // 8 vertices of a cube. [x, y, z]
    cube: [
        // 1   2
        //   F
        // 3   4
        // 1   2
        //   B
        // 3   4

        {
            x: -1,
            y: -1 + O,
            z: F,
        },
        {
            x: 1,
            y: -1 + O,
            z: F,
        },
        {
            x: -1,
            y: 1 + O,
            z: F,
        },
        {
            x: 1,
            y: 1 + O,
            z: F,
        },

        {
            x: -1,
            y: -1 + O,
            z: B,
        },
        {
            x: 1,
            y: -1 + O,
            z: B,
        },
        {
            x: -1,
            y: 1 + O,
            z: B,
        },
        {
            x: 1,
            y: 1 + O,
            z: B,
        },
    ]
}

let renders = {
    cube: []
}

let meshes = {
    cube: []
}

const rotate = (mesh=[], angle = [0, 0, 0]) => {
    const matrixDot = (A, B) => {
        var result = new Array(A.length).fill(0).map(row => new Array(B[0].length).fill(0));

        return result.map((row, i) => {
            return row.map((val, j) => {
                return A[i].reduce((sum, elm, k) => sum + (elm * B[k][j]), 0)
            })
        })
    }

    transformationMatrix = [
        [Math.sin(angle[0]), 0, 0],
        [0, Math.sin(angle[1]), 0],
        [0, 0, Math.sin(angle[2])],
    ]
    rotatedMesh = []

    mesh.forEach(vertex => {
        let arr = [vertex.x, vertex.y, vertex.z]
        let obj = {
            x: matrixDot(arr, transformationMatrix)[0],
            y: matrixDot(arr, transformationMatrix)[1],
            z: matrixDot(arr, transformationMatrix)[2],
        }
        rotatedMesh.push(obj)
    })

    return rotatedMesh
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
        x: point.x * canvas.width * .8 + canvas.width / 2,
        y: point.y * canvas.height + canvas.height / 2 - offset,
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

baseMeshes.cube.forEach(vertex => {
    point = scale(project(vertex))
    const x = point.x
    const y = point.y

    renders.cube.push({
        x: x,
        y: y,
    })
    meshes.cube.push({
        x: vertex.x,
        y: vertex.y,
        z: vertex.z,
    })
})

ctx.strokeStyle = "#303030"

const frame = () => {
    ctx.clearRect(0, 0, canvas.width, canvas.height)

    meshes.cube.forEach(vertex => {
        point = scale(project(vertex))
        const x = point.x
        const y = point.y

        if (document.querySelector("#circle").checked) {
            ctx.beginPath()
            ctx.arc(x, y, 10, 0, Math.PI * 2)
            ctx.stroke()
            ctx.closePath()
        }
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