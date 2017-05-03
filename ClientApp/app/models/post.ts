export class Post {
    public id: number
    
    constructor (
        public body: string,
        public views: number,
        public created: Date
        ) {}

}