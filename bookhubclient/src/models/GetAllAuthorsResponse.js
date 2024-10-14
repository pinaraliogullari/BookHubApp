export class GetAllAuthorsResponse {
    constructor(totalCount, authors) {
        this.totalCount = totalCount;
        this.authors = authors;
    }
}
