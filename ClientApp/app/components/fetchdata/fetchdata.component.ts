import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { PostsService } from '../../services/posts/posts.service';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html',
    providers: [PostsService]
})
export class FetchDataComponent {
    public posts: Post[];
    public message: any;
    public btnText: string;

    constructor(private _postsService: PostsService) {
        this.btnText = '+';
    }

    getPosts(){
        this.btnText = '......';
        this._postsService.getPosts()
            .subscribe(data => { this.posts = data as Post[];
                console.log(data);
            this.handleSucess();
        });
    }

    private handleSucess() {
        this.message = 'Got em!';
        this.btnText = '+'
    }
}

interface Post {
    body: string;
    views: number;
    created: Date; 
}
