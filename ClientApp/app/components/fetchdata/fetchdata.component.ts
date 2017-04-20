import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public posts: Post[];

    constructor(http: Http) {
        http.get('/api/posts/get').subscribe(result => {
            this.posts = result.json() as Post[];
        });
    }
}

interface Post {
    body: string;
    views: number;
    created: Date;   
}
