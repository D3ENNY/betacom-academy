export class Employee {
    enrollment: string
    name: string
    City: string
    address: string

    constructor(enrollment:string, name: string, city: string, address: string) {
        this.enrollment = enrollment
        this.name = name
        this.City = city
        this.address = address
    }

    toString() {
        return this.enrollment+ ' - '+ this.name+ ' - '+ this.City+ ' - '+ this.address
    }
}
