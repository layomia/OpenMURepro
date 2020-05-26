using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnique.OpenMU.Persistence.BasicModel
{
    /// <summary>
    /// A plain implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.ConnectServerDefinition"/>.
    /// </summary>
    public partial class ConnectServerDefinition : MUnique.OpenMU.DataModel.Configuration.ConnectServerDefinition, IIdentifiable, IConvertibleTo<ConnectServerDefinition>
    {
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="Client" />.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("client")]
        public GameClientDefinition RawClient
        {
            get { return base.Client as GameClientDefinition; }
            set { base.Client = value; }
        }

        /// <inheritdoc/>
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.DataModel.Configuration.GameClientDefinition Client
        {
            get
            {
                return base.Client;
            }

            set
            {
                base.Client = value;
            }
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            var baseObject = obj as IIdentifiable;
            if (baseObject != null)
            {
                return baseObject.Id == this.Id;
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <inheritdoc/>
        public ConnectServerDefinition Convert() => this;
    }


    /// <summary>
    /// A plain implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.GameClientDefinition"/>.
    /// </summary>
    public partial class GameClientDefinition : MUnique.OpenMU.DataModel.Configuration.GameClientDefinition, IIdentifiable, IConvertibleTo<GameClientDefinition>
    {
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            var baseObject = obj as IIdentifiable;
            if (baseObject != null)
            {
                return baseObject.Id == this.Id;
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <inheritdoc/>
        public GameClientDefinition Convert() => this;
    }

    /// <summary>
    /// The interface for all identifiable objects of the data model.
    /// </summary>
    public interface IIdentifiable
    {
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        Guid Id { get; set; }
    }

    /// <summary>
    /// Interface to support convert an object into another one.
    /// Useful to convert a persistent data model class into the basic model.
    /// </summary>
    /// <typeparam name="TTarget">The target type, e.g. of the basic model.</typeparam>
    public interface IConvertibleTo<out TTarget>
        where TTarget : class
    {
        /// <summary>
        /// Converts this instance into a new instance of <typeparamref name="TTarget"/>.
        /// If this instance is already of type <typeparamref name="TTarget"/>, this instance will be returned.
        /// </summary>
        /// <returns>The converted instance.</returns>
        TTarget Convert();
    }
}
