import { Injectable } from "@angular/core";
import { Http } from "@angular/http";

/**
 * @description
 * @class
 */
@Injectable()
export class PostsService {

  constructor(private http: Http) {
    
  }

  getPosts() {
    return this.http
      .get('api/posts/get')
      .map((response) => response.json());
  }

  createPost(data) {
    return this.http
      .post('api/posts/post', data)
      .map((response) => response.json());
  }

}
