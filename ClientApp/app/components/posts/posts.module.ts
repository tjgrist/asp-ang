// Angular Imports
import { NgModule } from '@angular/core';

// This Module's Components
import { PostsComponent } from './posts.component';
import { PostListComponent } from '../post-list/post-list.component';
import { PostDetailComponent } from '../post-detail/post-detail.component';

@NgModule({
    imports: [

    ],
    declarations: [
        PostsComponent,
    PostListComponent,
    PostDetailComponent
],
    exports: [
        PostsComponent,
    ]
})
export class PostsModule {

}
