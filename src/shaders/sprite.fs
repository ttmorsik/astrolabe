#version 330 core
in vec2 TexCoords;

out vec4 FragColor;

uniform sampler2D u_sprite;

void main() {
  FragColor = vec4(1.0, 1.0, 1.0, 1.0);
}
