import React from 'react';
import { connect } from 'react-redux';
import { Input, FormGroup, Label, Form } from 'reactstrap';

class Home extends React.Component {
    handleSubmit(e) {
        var t = e.target;
        var createPostCommand = {
            title: t.title.value,
            contentText: t.contentText.value,
            status : t.status.value,
            tag : t.tag.value
        };
        fetch('/Post/Create', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(createPostCommand)
        });
        e.preventDefault();
    }
render() {
    return (
        <Form action="/Post/Create" method="post" onSubmit={this.handleSubmit} id="postForm">
            <FormGroup>
                <Label for="title">Title</Label>
                <Input type="text" id="title" placeholder="Title" name="title" />
            </FormGroup>
            <FormGroup>
                <Label for="contentText">Content something</Label>
                <Input type="textarea" placeholder="Content Text.." id="contentText" name="contentText" />
            </FormGroup>
            <FormGroup>
                <Label for="status">Choice status</Label>
                <Input type="select" id="status" name="status">
                    <option value="1">Aktif</option>
                    <option value="0">Pasif</option>
                </Input>
            </FormGroup>
            <FormGroup>
                <Label for="tag">Choice tag</Label>
                <Input type="select" id="tag" name="tag">
                    <option value="1">Tag1</option>
                    <option value="0">Tag2</option>
                </Input>
            </FormGroup>
            <FormGroup>
                <Input type="submit" />
            </FormGroup>
        </Form>

    );
}
}
export default connect()(Home);
