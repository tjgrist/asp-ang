import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public posts: Post[];
    public message: any;
    public btnText: string;

    constructor(private http: Http) {
        http.get('/api/posts/get').subscribe(result => {
            this.posts = result.json() as Post[];
        });
        this.btnText = '+';
    }

    public sendPost(){
        var data = {
            created: new Date(),
            views: 5,
            body: 'lorem supra ipsum'
        };
        this.btnText = '......';
        this.http.post('api/posts/post', data).subscribe(result => {
            this.posts.push(result.json() as Post);
            this.handleSuccess();
        });
    }
    private handleSuccess() {
        this.message = 'Posted!';
        this.btnText = '+'
    }
}

interface Post {
    body: string;
    views: number;
    created: Date;   
}
