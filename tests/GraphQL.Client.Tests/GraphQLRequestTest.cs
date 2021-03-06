using Xunit;

namespace GraphQL.Client.Tests {

	public class GraphQLRequestTest {

		[Fact]
		public void ConstructorFact() {

			var graphQLRequest = new GraphQLRequest<string> { Query = "{hero{name}}" };
			Assert.NotNull(graphQLRequest.Query);
			Assert.Null(graphQLRequest.OperationName);
			Assert.Null(graphQLRequest.Variables);
		}

		[Fact]
		public void ConstructorExtendedFact() {
			var graphQLRequest = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			Assert.NotNull(graphQLRequest.Query);
			Assert.NotNull(graphQLRequest.OperationName);
			Assert.NotNull(graphQLRequest.Variables);
		}

		[Fact]
		public void Equality1Fact() {
			var graphQLRequest = new GraphQLRequest { Query = "{hero{name}}" };
			Assert.Equal(graphQLRequest, graphQLRequest);
		}

		[Fact]
		public void Equality2Fact() {
			var graphQLRequest1 = new GraphQLRequest { Query = "{hero{name}}" };
			var graphQLRequest2 = new GraphQLRequest { Query = "{hero{name}}" };
			Assert.Equal(graphQLRequest1, graphQLRequest2);
		}

		[Fact]
		public void Equality3Fact() {
			var graphQLRequest1 = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			var graphQLRequest2 = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			Assert.Equal(graphQLRequest1, graphQLRequest2);
		}

		[Fact]
		public void EqualityOperatorFact() {
			var graphQLRequest1 = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			var graphQLRequest2 = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			Assert.True(graphQLRequest1 == graphQLRequest2);
		}

		[Fact]
		public void InEquality1Fact() {
			var graphQLRequest1 = new GraphQLRequest { Query = "{hero{name1}}" };
			var graphQLRequest2 = new GraphQLRequest { Query = "{hero{name2}}" };
			Assert.NotEqual(graphQLRequest1, graphQLRequest2);
		}

		[Fact]
		public void InEquality2Fact() {
			var graphQLRequest1 = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue1"
				}
			};
			var graphQLRequest2 = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue2"
				}
			};
			Assert.NotEqual(graphQLRequest1, graphQLRequest2);
		}

		[Fact]
		public void InEqualityOperatorFact() {
			var graphQLRequest1 = new GraphQLRequest { Query = "{hero{name1}}" };
			var graphQLRequest2 = new GraphQLRequest { Query = "{hero{name2}}" };
			Assert.True(graphQLRequest1 != graphQLRequest2);
		}

		[Fact]
		public void GetHashCode1Fact() {
			var graphQLRequest1 = new GraphQLRequest { Query = "{hero{name}}" };
			var graphQLRequest2 = new GraphQLRequest { Query = "{hero{name}}" };
			Assert.True(graphQLRequest1.GetHashCode() == graphQLRequest2.GetHashCode());
		}

		[Fact]
		public void GetHashCode2Fact() {
			var graphQLRequest1 = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			var graphQLRequest2 = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			Assert.True(graphQLRequest1.GetHashCode() == graphQLRequest2.GetHashCode());
		}

		[Fact]
		public void PropertyQueryGetFact() {
			var graphQLRequest = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			Assert.Equal("{hero{name}}", graphQLRequest.Query);
		}

		[Fact]
		public void PropertyQuerySetFact() {
			var graphQLRequest = new GraphQLRequest<object> {
				Query = "{hero{name1}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			graphQLRequest.Query = "{hero{name2}}";
			Assert.Equal("{hero{name2}}", graphQLRequest.Query);
		}

		[Fact]
		public void PropertyOperationNameGetFact() {
			var graphQLRequest = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			Assert.Equal("operationName", graphQLRequest.OperationName);
		}

		[Fact]
		public void PropertyOperationNameNullGetFact() {
			var graphQLRequest = new GraphQLRequest { Query = "{hero{name}}" };
			Assert.Null(graphQLRequest.OperationName);
		}

		[Fact]
		public void PropertyOperationNameSetFact() {
			var graphQLRequest = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName1",
				Variables = new {
					varName = "varValue"
				}
			};
			graphQLRequest.OperationName = "operationName2";
			Assert.Equal("operationName2", graphQLRequest.OperationName);
		}

		[Fact]
		public void PropertyVariableGetFact() {
			var graphQLRequest = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue"
				}
			};
			Assert.Equal(new {
				varName = "varValue"
			}, graphQLRequest.Variables);
		}

		[Fact]
		public void PropertyVariableNullGetFact() {
			var graphQLRequest = new GraphQLRequest<object> { Query = "{hero{name}}" };
			Assert.Null(graphQLRequest.Variables);
		}

		[Fact]
		public void PropertyVariableSetFact() {
			var graphQLRequest = new GraphQLRequest<object> {
				Query = "{hero{name}}",
				OperationName = "operationName",
				Variables = new {
					varName = "varValue1"
				}
			};
			graphQLRequest.Variables = new {
				varName = "varValue2"
			};
			Assert.Equal(new {
				varName = "varValue2"
			}, graphQLRequest.Variables);
		}

	}

}
